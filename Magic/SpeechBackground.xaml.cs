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
using Windows.Media.SpeechRecognition;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Magic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpeechBackground : Page
    {
        SpeechRecognizer recognize = new SpeechRecognizer();

        public SpeechBackground()
        {
            this.InitializeComponent();

            BackgroundImage.BackgroundImageSwitch(backgroundPicture, inClockStoryboard, outClockStoryBoard);

            MirrorSpeechRecognition speechRecognition = new MirrorSpeechRecognition();

            speechRecognition.speechProcess(this);

        }

        
    }
}
