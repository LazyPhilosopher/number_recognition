using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MNIST_NeuronNetwork
{
    public partial class Form1 : Form
    {
        Neuron_Network network;
        public Form1()
        {
            InitializeComponent();
            network = new Neuron_Network();
        }

        private void MNIST_BMP_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openMNISTDialog = new OpenFileDialog();

            string line;

            openMNISTDialog.InitialDirectory = "\\";
            openMNISTDialog.Filter = "All files (*.*)|*.*|MNIST files(*.csv)|*.csv";
            openMNISTDialog.FilterIndex = 2;
            openMNISTDialog.RestoreDirectory = true;

            if (openMNISTDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openMNISTDialog.FileName;
                string output_addr = "";
                var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    while (true)
                    {
                        Bitmap Image = new Bitmap(28, 28);
                        char tmp;
                        string number = "";
                        int x = 0;
                        int y = 0;
                        int word = 0;
                        int brightness;
                        output_addr = "";

                        line = streamReader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        //textBox1.Text = Convert.ToString(line.Length);
                        for (int symbol = 0; symbol < line.Length; symbol++)
                        {
                            tmp = Convert.ToChar(line.Substring(symbol, 1));

                            if (tmp == ',' && word == 0)
                            {
                                //textBox1.Text = Convert.ToString(tmp);
                                output_addr += line.Substring(0, symbol);
                                number = "";
                                word++;
                            }
                            else if (tmp == ',')
                            {
                                brightness = Convert.ToInt32(number);
                                number = "";
                                Image.SetPixel(x, y, Color.FromArgb(255, 255 - brightness, 255 - brightness, 255 - brightness));
                                x++;
                                if (x == 28)
                                {
                                    x = 0;
                                    y++;

                                }
                            }
                            else
                            {
                                number = number + tmp;
                                if (symbol == line.Length - 1)
                                {
                                    brightness = Convert.ToInt32(number);
                                    Image.SetPixel(x, y, Color.FromArgb(255, 255 - brightness, 255 - brightness, 255 - brightness));
                                }
                            }

                            //Image.SetPixel(x, y, Color.FromArgb(152, 15, 198, 255));
                        }
                        LookWindow.Image = Image;
                        LookWindow.Refresh();
                        try
                        {
                            output_addr = @"MNIST Image\\" + output_addr + "\\" + output_addr + "_[" + Convert.ToString(Directory.GetFiles(@"MNIST Image\\" + output_addr).Length) + "].bmp";
                        }
                        catch (System.IO.DirectoryNotFoundException)
                        {
                            Directory.CreateDirectory(@"MNIST Image\\" + output_addr);
                            output_addr = @"MNIST Image\\" + output_addr + "\\" + output_addr + "_[0].bmp";
                        }
                        LogBox.Text += Convert.ToString(output_addr) + "\r\n";
                        LogBox.Refresh();
                        Image.Save(output_addr);

                    }
                }
            }
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {

            /*double[] input = new double[784];
            double[] answer = new double[10];
            double[] output = new double[10];

            int epochs = 100;
            double index = 0.3;
            string[] filePaths = Directory.GetFiles(@"MNIST Image\\", "*.bmp",
                                         SearchOption.AllDirectories);
            string image_addr;
            string image_name;
            Bitmap image;
            Bitmap percent_graph = new Bitmap(percent_box.Width * 999, percent_box.Height);
            double error_percent = 0;

            try
            {
                epochs = Convert.ToInt32(EpochBox.Text);
            }
            catch (FormatException)
            {
                epochs = 100;
                EpochBox.Text = "100";
            }
            try
            {
                index = Convert.ToInt32(IndexBox.Text);
            }
            catch (FormatException)
            {
                index = 0.3;
                IndexBox.Text = "0,3";
            }

            if (EpochBox.Text == "")
            {
                EpochBox.Text = "100";
            }
            if (IndexBox.Text == "")
            {
                IndexBox.Text = "0,3";
            }

            using (Graphics g = Graphics.FromImage(percent_graph))
            {
                g.Clear(Color.Black);
            }

            for (int epoch = 0; epoch < epochs; epoch++)
            {
                error_percent = 0;
                for (int file = 0; file < filePaths.Length; file++)
                {
                    image_addr = filePaths[file];
                    image_name = Path.GetFileName(image_addr);
                    image = new Bitmap(image_addr);
                    LookWindow.Image = image;
                    LookWindow.Refresh();

                    for (int x = 0; x < answer.Length; x++)
                    {
                        if (network.neuron_arrays[network.neuron_arrays.Length - 1][x].name == "unnamed")
                        {
                            network.neuron_arrays[network.neuron_arrays.Length - 1][x].name = new DirectoryInfo(Directory.GetDirectories(@"MNIST Image")[x]).Name;
                        }
                        if (network.neuron_arrays[network.neuron_arrays.Length - 1][x].name == Path.GetFileName(Path.GetDirectoryName(image_addr)))
                        {
                            answer[x] = 1;
                        }
                        else
                        {
                            answer[x] = 0;
                        }
                    }


                    for (int y = 0; y < 28; y++)
                    {
                        for (int x = 0; x < 28; x++)
                        {
                            input[x + y * x] = 255 * (1 - Convert.ToDouble(image.GetPixel(x, y).GetBrightness()));
                        }
                    }
                    output = network.Query(input);
                    LogBox.Clear();

                    double sum = 0;

                    for (int x = 0; x < output.Length; x++)
                    {
                        if (answer[x] == 1)
                        {
                            error_percent += (1 - output[x]) / filePaths.Length;
                        }
                        else
                        {
                            error_percent += output[x] / filePaths.Length;
                        }
                        sum += output[x];

                    }

                    for (int x = 0; x < output.Length; x++)
                    {
                        LogBox.Text += network.neuron_arrays[network.neuron_arrays.Length - 1][x].name + " => " + Convert.ToString((output[x] / sum) * 100).Substring(0, 4) + "%\r\n";
                    }
                    LogBox.Refresh();

                    network.Train(input, answer, index);
                    //Thread.Sleep(500);}
                }
                if (error_percent > 1)
                {
                    error_percent = 1;
                }
                try
                {
                    ErrorLabel.Text = Convert.ToString(error_percent * 100).Substring(0, 5) + "%";
                }
                catch (ArgumentOutOfRangeException)
                {
                    ErrorLabel.Text = "100%";
                }
                ErrorLabel.Refresh();

                using (Graphics g = Graphics.FromImage(percent_graph))
                {
                    int a = Convert.ToInt32((percent_graph.Width / epochs) * epoch);
                    int b = Convert.ToInt32(percent_graph.Height - percent_graph.Height * error_percent);
                    int c = Convert.ToInt32(percent_graph.Width / epochs);
                    int d = Convert.ToInt32(percent_graph.Height * error_percent);

                    g.DrawRectangle(new Pen(Color.Green, 1), new Rectangle(a, b, c, d));
                    g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(a, b, c, d));
                }
                percent_box.Image = percent_graph;
                percent_box.Refresh();


            }*/
            double[] input = {1.0, 0.5, -1.5};
            double[] answer = {0.208131, 0.22549215, 0.99742175};
            double index = 0.3;
            double[] output = new double[3];
            output = network.Query(input);
            network.Train(input, answer, index);
            output = network.Query(input);

        }

        private void AutoQueryButton_Click(object sender, EventArgs e)
        {
            double[] input = new double[784];
            double[] answer = new double[10];
            double[] output = new double[10];

            string[] filePaths = Directory.GetFiles(@"MNIST Image\\", "*.bmp",
                                         SearchOption.AllDirectories);
            string image_addr;
            string image_name;
            Bitmap image;
            Bitmap percent_graph = new Bitmap(percent_box.Width * 999, percent_box.Height);
            double error_percent = 0;

            LogBox.Clear();

            using (Graphics g = Graphics.FromImage(percent_graph))
            {
                g.Clear(Color.Black);
            }

            for (int file = 0; file < filePaths.Length; file++)
            {
                error_percent = 0;
                image_addr = filePaths[file];
                image_name = Path.GetFileName(image_addr);
                image = new Bitmap(image_addr);
                LookWindow.Image = image;
                LookWindow.Refresh();

                for (int x = 0; x < answer.Length; x++)
                {
                    if (network.neuron_arrays[network.neuron_arrays.Length - 1][x].name == "unnamed")
                    {
                        network.neuron_arrays[network.neuron_arrays.Length - 1][x].name = new DirectoryInfo(Directory.GetDirectories(@"MNIST Image")[x]).Name;
                    }
                    if (network.neuron_arrays[network.neuron_arrays.Length - 1][x].name == Path.GetFileName(Path.GetDirectoryName(image_addr)))
                    {
                        answer[x] = 1;
                    }
                    else
                    {
                        answer[x] = 0;
                    }
                }


                for (int y = 0; y < 28; y++)
                {
                    for (int x = 0; x < 28; x++)
                    {
                        input[x + y * x] = 255 * (1 - Convert.ToDouble(image.GetPixel(x, y).GetBrightness()));
                    }
                }
                output = network.Query(input);


                //LogBox.Clear();

                double sum = 0;
                bool mistake = false;
                for (int x = 0; x < output.Length; x++)
                {
                    if (answer[x] == 1)
                    {
                        error_percent += (1 - output[x]) / answer.Length;
                    }
                    else
                    {
                        error_percent += output[x] / answer.Length;
                        if (output[x] >= 0.5)
                        {
                            mistake = true;
                        }
                    }
                    sum += output[x];

                }
                if (mistake)
                {
                    LogBox.Text += "Error in " + Path.GetFileName(filePaths[file]) + "\r\n";
                }

                LogBox.Refresh();

                if (error_percent > 1)
                {
                    error_percent = 1;
                }
                try
                {
                    ErrorLabel.Text = Convert.ToString(error_percent * 100).Substring(0, 5) + "%";
                }
                catch (ArgumentOutOfRangeException)
                {
                    ErrorLabel.Text = "100%";
                }
                ErrorLabel.Refresh();

                using (Graphics g = Graphics.FromImage(percent_graph))
                {
                    int a = Convert.ToInt32((percent_graph.Width / filePaths.Length) * file);
                    int b = Convert.ToInt32(percent_graph.Height - percent_graph.Height * error_percent);
                    int c = Convert.ToInt32(percent_graph.Width / filePaths.Length);
                    int d = Convert.ToInt32(percent_graph.Height * error_percent);

                    g.DrawRectangle(new Pen(Color.Green, 1), new Rectangle(a, b, c, d));
                    g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(a, b, c, d));
                }
                percent_box.Image = percent_graph;
                percent_box.Refresh();
            }
        }

        private void ManualQueryButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openMNISTDialog = new OpenFileDialog();

            openMNISTDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\MNIST Image";
            openMNISTDialog.Filter = "All files (*.*)|*.*|.bmp files(*.bmp)|*.bmp";
            openMNISTDialog.FilterIndex = 2;
            openMNISTDialog.RestoreDirectory = true;

            if (openMNISTDialog.ShowDialog() == DialogResult.OK)
            {
                LogBox.Clear();
                double[] input = new double[784];
                double[] output;
                string file_addr = openMNISTDialog.FileName;
                string file_name = Path.GetDirectoryName(file_addr);
                Bitmap Image = new Bitmap(file_addr);

                LookWindow.Image = Image;
                for (int y = 0; y < 28; y++)
                {
                    for (int x = 0; x < 28; x++)
                    {
                        input[x + y * x] = 255 * (1 - Convert.ToDouble(Image.GetPixel(x, y).GetBrightness()));
                    }
                }

                output = network.Query(input);

                for (int x = 0; x < output.Length; x++)
                {
                    if (output[x] >= 0.75)
                    {
                        LogBox.Text += network.neuron_arrays[network.neuron_arrays.Length - 1][x].name + " => TRUE\r\n";
                    }
                    else if (output[x] >= 0.5)
                    {
                        LogBox.Text += network.neuron_arrays[network.neuron_arrays.Length - 1][x].name + " => MAYBE\r\n";
                    }
                    else if (output[x] < 0.5)
                    {
                        LogBox.Text += network.neuron_arrays[network.neuron_arrays.Length - 1][x].name + " => FALSE\r\n";
                    }
                }
            }
        }
    }
}