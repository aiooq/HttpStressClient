using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Windows.Forms;

namespace HttpStressClient
{
    public partial class Form1 : Form
    {
        static string url;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            url = textBox_url.Text;

            timer_request.Interval = Convert.ToInt32(textBox_timer_msc.Text);
            timer_request.Start();
        }
        private void button_stop_Click(object sender, EventArgs e)
        {
            timer_request.Stop();
        }

        private void timer_request_Tick(object sender, EventArgs e)
        {
            Req();
        }

        static readonly HttpClient client = new HttpClient();
        static async Task Req()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

#if DEBUG
                Console.WriteLine(responseBody);
#endif
            }
            catch (HttpRequestException e)
            {
#if DEBUG
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
#endif
            }
        }
    }
}
