using Python.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRED_BTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "";
                load_image_dialog.InitialDirectory = "C:\\";


                Dictionary<String, String> class_indices = new Dictionary<string, string>();

                class_indices.Add("Jimin", "지민");
                class_indices.Add("Jungkook", "정국");
                class_indices.Add("V", "뷔");



                if (python_path_box.Text == "" || python_path_box.Text == "파이썬 디렉토리")
                {
                    MessageBox.Show("파이썬 경로를 입력해주세요", "파이썬 경로를 입력해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    // var pythonPath = @"C:\Users\USER\AppData\Local\Programs\Python\Python38";
                    var pythonPath = @python_path_box.Text;

                    Environment.SetEnvironmentVariable("PATH", $@"{@pythonPath};" + Environment.GetEnvironmentVariable("PATH"));
                    Environment.SetEnvironmentVariable("PYTHONHOME", pythonPath);
                    Environment.SetEnvironmentVariable("PYTHONPATH", $@"{pythonPath}\Lib");

                    PythonEngine.PythonHome = @"C:\Users\USER\AppData\Local\Programs\Python\Python38";

                    if (load_image_dialog.ShowDialog() == DialogResult.OK)
                    {
                        filepath = load_image_dialog.FileName;
                        loaded_image.Load(@filepath);
                        loaded_image.SizeMode = PictureBoxSizeMode.StretchImage;

                        filepath = filepath.Replace(@"\", @"/");

                        using (Py.GIL())
                        {
                            //dynamic np = Py.Import("numpy");
                            //dynamic cv2 = Py.Import("cv2");
                            //dynamic keras = Py.Import("keras");

                            //var model = keras.models.load_model("./bts_cnn_model.h5");
                            //var dsize = (100, 100);
                            //var img = cv2.resize(cv2.imread(filepath), dsize);
                            //img = np.expand_dims(img, 0);
                            //var result = class_indices[np.argmax(model.predict(img))];


                            PyObject pred_bts = PythonEngine.ImportModule("pred_bts");
                            PyObject[] param = new PyObject[1];
                            param[0] = new PyString(filepath);
                            var result = pred_bts.InvokeMethod("predict", param).ToString();


                            result_label.Text = "예측결과: " + class_indices[result];
                        }
                    }
                }
                
            } catch(Exception ex)
            {
                MessageBox.Show("에러", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }



    }
}
