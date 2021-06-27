using System;
using System.Drawing;
using System.Windows.Forms;

namespace 농도변환기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            from = 0;
            FromTextBox.Text = from.ToString();
            var dat = new string[] { "%", "M", "m" };
            ToDropDownList.Items.AddRange(dat);
            FromDropDownList.Items.AddRange(dat);
            ToDropDownList.SelectedIndex = 0;
            FromDropDownList.SelectedIndex = 1;
        }
        public static DialogResult InputBox(string title, string content, ref double value)
        {
            Form form = new();
            Label label = new();
            TextBox textBox = new();
            Button buttonOk = new();
            Button buttonCancel = new();

            form.ClientSize = new Size(250, 100);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.Text = title;
            label.Text = content;
            textBox.Text = value.ToString();
            buttonOk.Text = "확인";
            buttonCancel.Text = "취소";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(15, 17, 100, 20);
            textBox.SetBounds(15, 40, 220, 20);
            buttonOk.SetBounds(85, 70, 70, 20);
            buttonCancel.SetBounds(165, 70, 70, 20);

            DialogResult dialogResult = form.ShowDialog();

            value = double.Parse(textBox.Text);
            return dialogResult;
        }
        double from;
        int from_mode = 0, to_mode = 0;

        private void FromDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            from_mode = FromDropDownList.SelectedIndex;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (from_mode == to_mode)
            {
                MessageBox.Show("입력과 출력의 단위가 동일 할 수 없습니다.");
            }
            else switch (from_mode)
                {
                    case 0:
                        if(to_mode == 1)
                        {
                            try
                            {
                                double d = 1;
                                InputBox("Requirement", "밀도가 필요합니다.", ref d);
                                double mw = 1;
                                InputBox("Requirement", "화학식량이 필요합니다.", ref mw);
                                ResultLabel.Text = (from / mw * d * 10).ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                double mw = 1;
                                InputBox("Requirement", "화학식량이 필요합니다.", ref mw);
                                ResultLabel.Text = (from / mw * (100 - from) * 1000).ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                    case 1:
                        if(to_mode == 0)
                        {
                            try
                            {
                                double d = 1;
                                InputBox("Requirement", "밀도가 필요합니다.", ref d);
                                double mw = 1;
                                InputBox("Requirement", "화학식량이 필요합니다.", ref mw);
                                ResultLabel.Text = (from * mw / 10 / d).ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                double d = 1;
                                InputBox("Requirement", "밀도가 필요합니다.", ref d);
                                double mw = 1;
                                InputBox("Requirement", "화학식량이 필요합니다.", ref mw);
                                ResultLabel.Text = (from / (d - (from * mw / 1000))).ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                    case 2:
                        if(to_mode == 0)
                        {
                            //TODO
                        }
                        else
                        {
                            try
                            {
                                double d = 1;
                                InputBox("Requirement", "밀도가 필요합니다.", ref d);
                                double mw = 1;
                                InputBox("Requirement", "화학식량이 필요합니다.", ref mw);
                                ResultLabel.Text = (from / ((from * mw / 1000 + 1) / d)).ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                }
        }

        private void ToDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            to_mode = ToDropDownList.SelectedIndex;
        }

        private void FromTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                from = double.Parse(FromTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("올바른 값을 입력해주세요!");
            }
        }
    }
}
