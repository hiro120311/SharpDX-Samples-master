using System;
using System.Windows.Forms;
using SharpDX.Windows;

namespace HelloTexture
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var form = new MyForm
            {
                Width = 1280,
                Height = 800
            };
            form.Show();
            
            using (var app = new HelloTexture())
            {
                app.Initialize(form);

                using (var loop = new RenderLoop(form))
                {
                    while (loop.NextFrame())
                    {
                        app.Update();
                        app.Render();
                    }
                }
            }
        }
    }

    class MyForm : RenderForm
    {
        public MyForm()
        {
            // イベントを追加
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseClick += Form1_MouseClick;
            this.MouseDoubleClick += Form1_MouseDoubleClick;
        }

      

        // マウスボタン押し込み
	    private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("{0}:MouseDown", e.Button);
        }
        // マウスボタン解放
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("{0}:MouseUp", e.Button);
        }
        // マウスボタンクリック
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("{0}:Click", e.Button);
        }
        // マウスボタンクリック
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("{0}:DoubleClick", e.Button);
        }
    }


}
