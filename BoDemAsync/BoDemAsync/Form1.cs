using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoDemAsync
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancelTokenSource;
        private static readonly string pauseButtonText = "Pause";
        private static readonly string resumeButtonText = "Resume";
        private static readonly string startButtonText = "Start";
        private static readonly string instructionLabelText = "Please Input Number";
        private static readonly string resetButtonText = "Reset";
        private static readonly char[] forbbidenChar = { '-', '+', '0', ' ' };
        private int theRetrievedValue;
        private bool isPaused, isTextChanged;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetButton.Text = resetButtonText;
            CounterControlButton.Text = startButtonText;
            instructionLabel.Text = instructionLabelText;

            CurrentNumberLabel.Hide();
            MaxiumNumberLabel.Hide();
            ResetButton.Enabled = false;
            CounterControlButton.Enabled = false;
            UserInputTextBox.Text = 0.ToString();
            isTextChanged = false;
        }

        private async Task CountingTaskAsync(CancellationToken cancelToken)
        {
            await Task.Run(() =>
            {
                for (int i = int.Parse(CurrentNumberLabel.Text); i <= theRetrievedValue; i++)
                {
                    cancelToken.ThrowIfCancellationRequested();
                    Invoke(new MethodInvoker(() =>
                    {
                        progressBar1.Value = i;
                        CurrentNumberLabel.Text = i.ToString();
                    }));
                    Thread.Sleep(500);
                }
            });
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(ex.Message);
            Reset();
        }

        private void CounterControl(object sender, EventArgs e)
        {
            if (CounterControlButton.Text.Equals(pauseButtonText))
            {
                Pause();
                return;
            }
            else if (CounterControlButton.Text.Equals(resumeButtonText))
                isPaused = false;

            StartCountingTask().ContinueWith((task) =>
            {
                if (isPaused == true)
                    return;

                if (task.IsCanceled)
                {
                    Invoke(new MethodInvoker(() => Reset()));
                    return;
                }
                if (task.Exception != null)
                {
                    var error = task.Exception.Flatten();
                    Invoke(new MethodInvoker(() => HandleException(error.InnerException ?? error)));
                    return;
                }
                Invoke(new MethodInvoker(() =>
                {
                    MessageBox.Show("Finish counting!");
                    Reset();
                }));
            });
        }

        private Task StartCountingTask()
        {
            cancelTokenSource = new CancellationTokenSource();
            CurrentNumberLabel.Show();
            MaxiumNumberLabel.Show();
            MaxiumNumberLabel.Text = "/ " + theRetrievedValue;
            progressBar1.Maximum = theRetrievedValue;
            UserInputTextBox.Enabled = false;
            ResetButton.Enabled = true;
            CounterControlButton.Text = pauseButtonText;
            return CountingTaskAsync(cancelTokenSource.Token);
        }

        private void Pause()
        {
            isPaused = true;
            if (cancelTokenSource != null)
            {
                cancelTokenSource.Cancel();
                cancelTokenSource.Dispose();
                cancelTokenSource = null;
            }
            CounterControlButton.Text = resumeButtonText;
        }

        private void TextChangedEvent(object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                isTextChanged = false;
                return;
            }
            isTextChanged = true;
            string trimedRetrievedValue = UserInputTextBox.Text.TrimStart(forbbidenChar).TrimEnd(' ');
            int oldRetrievedValue = theRetrievedValue;
            if (trimedRetrievedValue.Length == 0)
            {
                theRetrievedValue = 0;
                UserInputTextBox.Text = 0.ToString();
                CounterControlButton.Enabled = false;
                return;
            }
            if (!int.TryParse(trimedRetrievedValue, out theRetrievedValue))
            {
                UserInputTextBox.Text = oldRetrievedValue + "";
                theRetrievedValue = oldRetrievedValue;
                return;
            }

            if (theRetrievedValue == 0)
                CounterControlButton.Enabled = false;
            else
                CounterControlButton.Enabled = true;

            UserInputTextBox.Text = trimedRetrievedValue;

            if (isTextChanged)
                isTextChanged = false;
        }

        private void KeyDownEventForTextBox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CounterControlButton.Enabled == true)
                {
                    StartCountingTask().ContinueWith((task) =>
                    {
                        if (isPaused == true)
                            return;

                        if (task.IsCanceled)
                        {
                            Invoke(new MethodInvoker(() => Reset()));
                            return;
                        }
                        if (task.Exception != null)
                        {
                            var error = task.Exception.Flatten();
                            Invoke(new MethodInvoker(() => HandleException(error.InnerException ?? error)));
                            return;
                        }
                        Invoke(new MethodInvoker(() =>
                        {
                            MessageBox.Show("Finish counting!");
                            Reset();
                        }));
                    });
                }

                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                UserInputTextBox.Text = (theRetrievedValue + 1).ToString();
                return;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (theRetrievedValue == 0)
                    return;

                UserInputTextBox.Text = (theRetrievedValue - 1).ToString();
                return;
            }
        }

        private void Reset()
        {
            if (cancelTokenSource != null)
            {
                cancelTokenSource.Cancel();
                cancelTokenSource.Dispose();
                cancelTokenSource = null;
            }
            CounterControlButton.Text = startButtonText;
            ResetButton.Enabled = false;
            CurrentNumberLabel.Text = "0";
            MaxiumNumberLabel.Text = "0";
            MaxiumNumberLabel.Hide();
            CurrentNumberLabel.Hide();
            progressBar1.Value = 0;
            UserInputTextBox.Enabled = true;
            UserInputTextBox.Text = 0.ToString();
            isTextChanged = false;
            isPaused = false;
        }

        private void ResetButtonClickEvent(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
