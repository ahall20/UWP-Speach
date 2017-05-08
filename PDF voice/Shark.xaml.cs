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
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.FileProperties;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PDF_voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shark : Page
    {
        public string a = "";
        SpeechSynthesizer synth = new SpeechSynthesizer();
        MediaElement elem = new MediaElement();

        public Shark()
            
        {
            this.InitializeComponent();
            read.Visibility = Visibility.Collapsed;
            txtb.Visibility = Visibility.Collapsed;
            img.Visibility = Visibility.Collapsed;
            
            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //MediaElement elem = new MediaElement();
            synth.Voice = SpeechSynthesizer.AllVoices.First(gender => gender.Gender == VoiceGender.Female);
            SpeechSynthesisStream stre = await synth.SynthesizeTextToStreamAsync(a);
            elem.SetSource(stre, stre.ContentType);
            txtb.Text = a;
            txtb.Visibility = Visibility.Visible;
            a = "";
            
            {

            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
            elem.Stop();
            txtb.Text = "";
            txtb.Visibility = Visibility.Collapsed;
            img.Visibility = Visibility.Collapsed;

        }

        private async void Chap_1_Click(object sender, RoutedEventArgs e)
        {
            a = "In this chapter we will take a look at the basic programming terminology and we will write our first C# program. We will familiarize ourselves with programming – what it means and its connection to computers and programming languages. Briefly, we will review the different stages of software development. We will introduce the C# language, the .NET platform and the different Microsoft technologies used in software development. We will examine what tools we need to program in C#. We will use the C# language to write our first computer program, compile and run it from the command line as well as from Microsoft Visual Studio integrated development environment. We will review the MSDN Library – the documentation of the .NET Framework. It will help us with our exploration of the features of the platform and the language. What Does It Mean To Program? Nowadays computers have become irreplaceable. We use them to solve complex problems at the workplace, look for driving directions, have fun and communicate. They have countless applications in the business world, the entertainment industry, telecommunications and finance. It’s not an overstatement to say that computers build the neural system of our contemporary society and it is difficult to imagine its existence without them. Despite the fact that computers are so wide-spread, few people know how they really work. In reality, it is not the computers, but the programs (the software), which run on them, that matter. It is the software that makes computers valuable to the end-user, allowing for many different types of services that change our lives. How Do Computers Process Information? In order to understand what it means to program, we can roughly compare a computer and its operating system to a large factory with all its workshops, warehouses and transportation.This rough comparison makes it easier to imagine the level of complexity present in a contemporary computer.There are many processes running on a computer, and they represent the workshops and production lines in a factory. The hard drive, along with the files on it, and the operating memory (RAM) represent the warehouses, and the different protocols are the transportation systems, which provide the input and output of information. The different types of products made in a factory come from different workshops. They use raw materials from the warehouses and store the completed goods back in them. The raw materials are transported to the warehouses by the suppliers and the completed product is transported from the warehouses to the outlets. To accomplish this, different types of transportation are used. Raw materials enter the factory, go through different stages of processing and leave the factory transformed into products. Each factory converts the raw materials into a product ready for consumption. The computer is a machine for information processing. Unlike the factory in our comparison, for the computer, the raw material and the product are the same thing – information. In most cases, the input information is taken from any of the warehouses (files or RAM), to where it has been previously transported. Afterwards, it is processed by one or more processes and it comes out modified as a new product. Web based applications serve as a prime example. They use HTTP to transfer raw materials and products, and information processing usually has to do with extracting content from a database and preparing it for visualization in the form of HTML. Managing the Computer The whole process of manufacturing products in a factory has many levels of management. The separate machines and assembly lines have operators, the workshops have managers and the factory as a whole is run by general executives. Every one of them controls processes on a different level. The machine operators serve on the lowest level – they control the machines with buttons and levers. The next level is reserved for the workshop managers. And on the highest level, the general executives manage the different aspects of the manufacturing processes in the factory. They do that by issuing orders. It is the same with computers and software – they have many levels of management and control. The lowest level is managed by the processor and its registries (this is accomplished by using machine programs at a low level) – we can compare it to controlling the machines in the workshops. The different responsibilities of the operating system (Windows 7 for example), like the file system, peripheral devices, users and communication protocols, are controlled at a higher level – we can compare it to the management of the different workshops and departments in the factory. At the highest level, we can find the application software. It runs a whole ensemble of processes, which require a huge amount of processor operations. This is the level of the general executives, who run the whole factory in order to maximize the utilization of the resources and to produce quality results. The Essence of Programming The essence of programming is to control the work of the computer on all levels. This is done with the help of orders and commands from the programmer, also known as programming instructions. To program means to organize the work of the computer through sequences of instructions. These commands (instructions) are given in written form and are implicitly followed by the computer (respectively by the operating system, the CPU and the peripheral devices). A sequence of steps to achieve, complete some work or obtain some result is called an algorithm. This is how programming is related to algorithms. Programming involves describing what you want the computer to do by a sequence of steps, by algorithms. Programmers are the people who create these instructions, which control computers. These instructions are called programs. Numerous programs exist, and they are created using different kinds of programming languages. Each language is oriented towards controlling the computer on a different level. There are languages oriented towards the machine level (the lowest) – Assembler for example. Others are most useful at the system level (interacting with the operating system), like C. There are also high level languages used to create application programs. Such languages include C#, Java, C++, PHP, Visual Basic, Python, Ruby, Perl, JavaScript and others. In this book we will take a look at the C# programming language – a modern high level language. When a programmer uses C#, he gives commands in high level, like from the position of a general executive in a factory. The instructions given in the form of programs written in C# can access and control almost all computer resources directly or via the operating system. Before we learn how to write simple C# programs, let’s take a good look at the different stages of software development, because programming, despite being the most important stage, is not the only one. Stages in Software Development Writing software can be a very complex and time-consuming task, involving a whole team of software engineers and other specialists. As a result, many methods and practices, which make the life of programmers easier, have emerged. All they have in common is that the development of each software product goes through several different stages: - Gathering the requirements for the product and creating a task; - Planning and preparing the architecture and design;- Implementation (includes the writing of program code); - Product trials (testing); - Deployment and exploitation; - Support. Implementation, testing, deployment and support are mostly accomplished using programming.Gathering the Requirements In the beginning, only the idea for a certain product exists. It includes a list of requirements, which define actions by the user and the computer. In the general case, these actions make already existing activities easier – calculating salaries, calculating ballistic trajectories or searching for the shortest route on Google maps are some examples. In many cases the software implements a previously nonexistent functionality such as automation of a certain activity. The requirements for the product are usually defined in the form of documentation, written in English or any other language. There is no programming done at this stage. The requirements are defined by experts, who are familiar with the problems in a certain field. They can also write them up in such a way that they are easy to understand by the programmers. In the general case, these experts are not programming specialists, and they are called business analysts. Planning and Preparing the Architecture and Design After all the requirements have been gathered comes the planning stage. At this stage, a technical plan for the implementation of the project is created, describing the platforms, technologies and the initial architecture(design) of the program.This step includes a fair amount of creative work, which is done by software engineers with a lot of experience.They are sometimes called software architects.According to the requirements, the following parts are chosen: -The type of the application – for example console application, desktop application(GUI, Graphical User Interface application), client - server application, Web application, Rich Internet Application(RIA), mobile application, peer - to - peer application or other; -The architecture of the software – for example single layer, double layer, triple layer, multi - layer or SOA architecture; -The programming language most suitable for the implementation – for example C#, Java, PHP, Python, Ruby, JavaScript or C++, or a combination of different languages; - The technologies that will be used: platform (Microsoft .NET, Java EE, LAMP or another), database server (Oracle, SQL Server, MySQL, NoSQL ";
            read.Visibility = Visibility.Visible;
            img.Visibility = Visibility.Visible;
            elem.Stop();
          
            
            }

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.img.Source = new BitmapImage() { UriSource = new Uri("C:/Users/wwstudent/Documents/Visual Studio 2017/Projects/PDF voice/PDF voice/Assets/Shark.png", UriKind.Absolute) };
        }

        private void Button_stop(object sender, RoutedEventArgs e)
        {
            elem.Stop();
            txtb.Text = "";
            txtb.Visibility = Visibility.Collapsed;
            img.Visibility = Visibility.Collapsed;
            
        }
        private void play(object sender, RoutedEventArgs e)
        {
            elem.Play();
        }

        private void pause(object sender, RoutedEventArgs e)
        {
            elem.Pause();
        }
    }
    }

