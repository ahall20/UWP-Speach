using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.SpeechSynthesis;
using Windows.Media.Ocr;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Pickers;
using System.Xml;
using Windows.Media.SpeechRecognition;
using Windows.Globalization;




// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PDF_voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string a;
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        
        
private  void Button_Click(object sender, RoutedEventArgs e)
        {
            //Sets whatever is set to global string a to be said and after said button becomes invisible
            
           
            txt.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            Language la = new Language("en");
            OcrEngine ocr = OcrEngine.TryCreateFromLanguage(la);
            this.Frame.Navigate(typeof(Coding), null);
            
        }
           
            
            
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            a = "how are you today";
           
            this.Frame.Navigate(typeof(Howto), null);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //What is entered into text box is set to global variable a
            a = txt.Text;
            
            this.Frame.Navigate(typeof(Shark), null);

        }
    }
}
