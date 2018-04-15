using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechRecognition;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Magic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PhotoGallery : Page
    {
        private SpeechRecognizer recognize;

        public PhotoGallery()
        {
            this.InitializeComponent();    

            PhotoRotation.RotateImageGallery(ImageRotation, inStoryboard, outStoryBoard);

            speechProcess();

        }

        public async void speechProcess()
        {
            recognize = new SpeechRecognizer();

            recognize.ContinuousRecognitionSession.ResultGenerated += MyRecognizer_ResultGenerated;

            var GrammarConstraint = new SpeechRecognitionListConstraint(NavigatePage.listConstraint);

            recognize.Constraints.Add(GrammarConstraint);

            await recognize.CompileConstraintsAsync();

            SpeechRecognitionCompilationResult CompilationResult = await recognize.CompileConstraintsAsync();

            if (CompilationResult.Status == SpeechRecognitionResultStatus.Success)
            {
                await recognize.ContinuousRecognitionSession.StartAsync();
            }

        }

        private async void MyRecognizer_ResultGenerated(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionResultGeneratedEventArgs args)
        {

            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {

                if (args.Result.Text.Equals("future forecast") || args.Result.Text.Equals("weather forecast") || args.Result.Text.Equals("forecast"))
                {
                    this.Frame.Navigate(typeof(WeatherForecast));

                }
                else if (args.Result.Text.Equals("Go Home"))
                {
                    this.Frame.Navigate(typeof(MainPage));

                }
                else if (args.Result.Text.Equals("Britters and Greggers"))
                {
                    this.Frame.Navigate(typeof(PhotoGallery));
                }
            });
        }

    }
}
