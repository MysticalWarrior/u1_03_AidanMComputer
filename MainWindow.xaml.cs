/*
 * Aidan McClung
 * 2/16/2018
 * u1_03_AidanMComputer
 * Displays computer parts to build a computer
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace u1_03_AidanMComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowMotherBoard_Click(object sender, RoutedEventArgs e)
        {
            ShowMotherBoard.Background = Brushes.DarkGray;
            ShowCPU.Background = Brushes.LightGray;
            ShowCase.Background = Brushes.LightGray;
            ShowGPU.Background = Brushes.LightGray;
            ShowRAM.Background = Brushes.LightGray;
            ShowPSU.Background = Brushes.LightGray;
            ShowHDD.Background = Brushes.LightGray;
            MotherBoardDescription.Visibility = Visibility.Visible;
            MotherBoardImage.Visibility = Visibility.Visible;
            MotherBoardPrice.Visibility = Visibility.Visible;
            MotherBoardLinkText.Visibility = Visibility.Visible;
            CaseDescription.Visibility = Visibility.Collapsed;
            CaseImage.Visibility = Visibility.Collapsed;
            CasePrice.Visibility = Visibility.Collapsed;
            CaseLinkText.Visibility = Visibility.Collapsed;
            CPUDescription.Visibility = Visibility.Collapsed;
            CPUImage.Visibility = Visibility.Collapsed;
            CPULinkText.Visibility = Visibility.Collapsed;
            CPUPrice.Visibility = Visibility.Collapsed;
            GPUDescription.Visibility = Visibility.Collapsed;
            GPULinkText.Visibility = Visibility.Collapsed;
            GPUPrice.Visibility = Visibility.Collapsed;
            RAMDescription.Visibility = Visibility.Collapsed;
            RAMImage.Visibility = Visibility.Collapsed;
            RAMLinkText.Visibility = Visibility.Collapsed;
            RAMPrice.Visibility = Visibility.Collapsed;
            PSUDescription.Visibility = Visibility.Collapsed;
            PSUImage.Visibility = Visibility.Collapsed;
            PSULinkText.Visibility = Visibility.Collapsed;
            PSUPrice.Visibility = Visibility.Collapsed;
            HDDDescription.Visibility = Visibility.Collapsed;
            HDDImage.Visibility = Visibility.Collapsed;
            HDDLinkText.Visibility = Visibility.Collapsed;
            HDDPrice.Visibility = Visibility.Collapsed;
        }

        private void ShowCPU_Click(object sender, RoutedEventArgs e)
        {
            ShowMotherBoard.Background = Brushes.LightGray;
            ShowCPU.Background = Brushes.DarkGray;     
            ShowCase.Background = Brushes.LightGray;
            ShowGPU.Background = Brushes.LightGray;
            ShowRAM.Background = Brushes.LightGray;
            ShowPSU.Background = Brushes.LightGray;
            ShowHDD.Background = Brushes.LightGray;
            MotherBoardDescription.Visibility = Visibility.Collapsed;
            MotherBoardImage.Visibility = Visibility.Collapsed;
            MotherBoardPrice.Visibility = Visibility.Collapsed;
            CaseDescription.Visibility = Visibility.Collapsed;
            CaseImage.Visibility = Visibility.Collapsed;
            CasePrice.Visibility = Visibility.Collapsed;
            CPUDescription.Visibility = Visibility.Visible;
            CPUImage.Visibility = Visibility.Visible;
            CPULinkText.Visibility = Visibility.Visible;
            CPUPrice.Visibility = Visibility.Visible;
            CaseLinkText.Visibility = Visibility.Collapsed;
            MotherBoardLinkText.Visibility = Visibility.Collapsed;
            GPUDescription.Visibility = Visibility.Collapsed;
            GPULinkText.Visibility = Visibility.Collapsed;
            GPUPrice.Visibility = Visibility.Collapsed;
            RAMDescription.Visibility = Visibility.Collapsed;
            RAMImage.Visibility = Visibility.Collapsed;
            RAMLinkText.Visibility = Visibility.Collapsed;
            RAMPrice.Visibility = Visibility.Collapsed;
            PSUDescription.Visibility = Visibility.Collapsed;
            PSUImage.Visibility = Visibility.Collapsed;
            PSULinkText.Visibility = Visibility.Collapsed;
            PSUPrice.Visibility = Visibility.Collapsed;
            HDDDescription.Visibility = Visibility.Collapsed;
            HDDImage.Visibility = Visibility.Collapsed;
            HDDLinkText.Visibility = Visibility.Collapsed;
            HDDPrice.Visibility = Visibility.Collapsed;
        }

        private void ShowCase_Click(object sender, RoutedEventArgs e)
        {
            ShowCase.Background = Brushes.DarkGray;
            ShowMotherBoard.Background = Brushes.LightGray;
            ShowCPU.Background = Brushes.LightGray;
            ShowGPU.Background = Brushes.LightGray;
            ShowRAM.Background = Brushes.LightGray;
            ShowPSU.Background = Brushes.LightGray;
            ShowHDD.Background = Brushes.LightGray;
            MotherBoardDescription.Visibility = Visibility.Collapsed;
            MotherBoardImage.Visibility = Visibility.Collapsed;
            MotherBoardPrice.Visibility = Visibility.Collapsed;
            CaseDescription.Visibility = Visibility.Visible;
            CaseImage.Visibility = Visibility.Visible;
            CasePrice.Visibility = Visibility.Visible;
            CPUDescription.Visibility = Visibility.Collapsed;
            CPUImage.Visibility = Visibility.Collapsed;
            CPULinkText.Visibility = Visibility.Collapsed;
            CPUPrice.Visibility = Visibility.Collapsed;
            CaseLinkText.Visibility = Visibility.Visible;
            MotherBoardLinkText.Visibility = Visibility.Collapsed;
            GPUDescription.Visibility = Visibility.Collapsed;
            GPULinkText.Visibility = Visibility.Collapsed;
            GPUPrice.Visibility = Visibility.Collapsed;
            RAMDescription.Visibility = Visibility.Collapsed;
            RAMImage.Visibility = Visibility.Collapsed;
            RAMPrice.Visibility = Visibility.Collapsed;
            RAMLinkText.Visibility = Visibility.Collapsed;
            PSUDescription.Visibility = Visibility.Collapsed;
            PSUImage.Visibility = Visibility.Collapsed;
            PSULinkText.Visibility = Visibility.Collapsed;
            PSUPrice.Visibility = Visibility.Collapsed;
            HDDDescription.Visibility = Visibility.Collapsed;
            HDDImage.Visibility = Visibility.Collapsed;
            HDDLinkText.Visibility = Visibility.Collapsed;
            HDDPrice.Visibility = Visibility.Collapsed;
        }

        private void CPULink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void MotherBoardLink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void CaseLink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void ShowGPU_Click(object sender, RoutedEventArgs e)
        {
            ShowCase.Background = Brushes.LightGray;
            ShowMotherBoard.Background = Brushes.LightGray;
            ShowCPU.Background = Brushes.LightGray;
            ShowGPU.Background = Brushes.DarkGray;
            ShowRAM.Background = Brushes.LightGray;
            ShowPSU.Background = Brushes.LightGray;
            ShowHDD.Background = Brushes.LightGray;
            MotherBoardDescription.Visibility = Visibility.Collapsed;
            MotherBoardImage.Visibility = Visibility.Collapsed;
            MotherBoardPrice.Visibility = Visibility.Collapsed;
            CaseDescription.Visibility = Visibility.Collapsed;
            CaseImage.Visibility = Visibility.Collapsed;
            CasePrice.Visibility = Visibility.Collapsed;
            CPUDescription.Visibility = Visibility.Collapsed;
            CPUImage.Visibility = Visibility.Collapsed;
            CPULinkText.Visibility = Visibility.Collapsed;
            CPUPrice.Visibility = Visibility.Collapsed;
            CaseLinkText.Visibility = Visibility.Collapsed;
            MotherBoardLinkText.Visibility = Visibility.Collapsed;
            GPUDescription.Visibility = Visibility.Visible;
            GPULinkText.Visibility = Visibility.Visible;
            GPUPrice.Visibility = Visibility.Collapsed;
            RAMDescription.Visibility = Visibility.Collapsed;
            RAMImage.Visibility = Visibility.Collapsed;
            RAMLinkText.Visibility = Visibility.Collapsed;
            RAMPrice.Visibility = Visibility.Collapsed;
            PSUDescription.Visibility = Visibility.Collapsed;
            PSUImage.Visibility = Visibility.Collapsed;
            PSUPrice.Visibility = Visibility.Collapsed;
            PSULinkText.Visibility = Visibility.Collapsed;
            HDDDescription.Visibility = Visibility.Collapsed;
            HDDImage.Visibility = Visibility.Collapsed;
            HDDLinkText.Visibility = Visibility.Collapsed;
            HDDPrice.Visibility = Visibility.Collapsed;
        }

        private void GPULink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void ShowRAM_Click(object sender, RoutedEventArgs e)
        {
            ShowCase.Background = Brushes.LightGray;
            ShowMotherBoard.Background = Brushes.LightGray;
            ShowCPU.Background = Brushes.LightGray;
            ShowGPU.Background = Brushes.LightGray;
            ShowRAM.Background = Brushes.DarkGray;
            ShowPSU.Background = Brushes.LightGray;
            ShowHDD.Background = Brushes.LightGray;
            MotherBoardDescription.Visibility = Visibility.Collapsed;
            MotherBoardImage.Visibility = Visibility.Collapsed;
            MotherBoardPrice.Visibility = Visibility.Collapsed;
            CaseDescription.Visibility = Visibility.Collapsed;
            CaseImage.Visibility = Visibility.Collapsed;
            CasePrice.Visibility = Visibility.Collapsed;
            CPUDescription.Visibility = Visibility.Collapsed;
            CPUImage.Visibility = Visibility.Collapsed;
            CPULinkText.Visibility = Visibility.Collapsed;
            CPUPrice.Visibility = Visibility.Collapsed;
            CaseLinkText.Visibility = Visibility.Collapsed;
            MotherBoardLinkText.Visibility = Visibility.Collapsed;
            GPUDescription.Visibility = Visibility.Collapsed;
            GPULinkText.Visibility = Visibility.Collapsed;
            GPUPrice.Visibility = Visibility.Collapsed;
            RAMDescription.Visibility = Visibility.Visible;
            RAMImage.Visibility = Visibility.Visible;
            RAMLinkText.Visibility = Visibility.Visible;
            RAMPrice.Visibility = Visibility.Visible;
            PSUDescription.Visibility = Visibility.Collapsed;
            PSUImage.Visibility = Visibility.Collapsed;
            PSULinkText.Visibility = Visibility.Collapsed;
            PSUPrice.Visibility = Visibility.Collapsed;
            HDDDescription.Visibility = Visibility.Collapsed;
            HDDImage.Visibility = Visibility.Collapsed;
            HDDLinkText.Visibility = Visibility.Collapsed;
            HDDPrice.Visibility = Visibility.Collapsed;
        }

        private void RAMLink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void ShowPSU_Click(object sender, RoutedEventArgs e)
        {
            ShowMotherBoard.Background = Brushes.LightGray;
            ShowCPU.Background = Brushes.LightGray;
            ShowCase.Background = Brushes.LightGray;
            ShowGPU.Background = Brushes.LightGray;
            ShowRAM.Background = Brushes.LightGray;
            ShowPSU.Background = Brushes.DarkGray;
            ShowHDD.Background = Brushes.LightGray;
            MotherBoardDescription.Visibility = Visibility.Collapsed;
            MotherBoardImage.Visibility = Visibility.Collapsed;
            MotherBoardPrice.Visibility = Visibility.Collapsed;
            CaseDescription.Visibility = Visibility.Collapsed;
            CaseImage.Visibility = Visibility.Collapsed;
            CasePrice.Visibility = Visibility.Collapsed;
            CPUDescription.Visibility = Visibility.Collapsed;
            CPUImage.Visibility = Visibility.Collapsed;
            CPULinkText.Visibility = Visibility.Collapsed;
            CPUPrice.Visibility = Visibility.Collapsed;
            CaseLinkText.Visibility = Visibility.Collapsed;
            MotherBoardLinkText.Visibility = Visibility.Collapsed;
            GPUDescription.Visibility = Visibility.Collapsed;
            GPULinkText.Visibility = Visibility.Collapsed;
            GPUPrice.Visibility = Visibility.Collapsed;
            RAMDescription.Visibility = Visibility.Collapsed;
            RAMImage.Visibility = Visibility.Collapsed;
            RAMLinkText.Visibility = Visibility.Collapsed;
            RAMPrice.Visibility = Visibility.Collapsed;
            PSUDescription.Visibility = Visibility.Visible;
            PSUImage.Visibility = Visibility.Visible;
            PSUPrice.Visibility = Visibility.Visible;
            PSULinkText.Visibility = Visibility.Visible;
            HDDDescription.Visibility = Visibility.Collapsed;
            HDDImage.Visibility = Visibility.Collapsed;
            HDDLinkText.Visibility = Visibility.Collapsed;
            HDDPrice.Visibility = Visibility.Collapsed;
        }

        private void PSULink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void HDDLink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void ShowHDD_Click(object sender, RoutedEventArgs e)
        {
            ShowMotherBoard.Background = Brushes.LightGray;
            ShowCPU.Background = Brushes.LightGray;
            ShowCase.Background = Brushes.LightGray;
            ShowGPU.Background = Brushes.LightGray;
            ShowRAM.Background = Brushes.LightGray;
            ShowPSU.Background = Brushes.LightGray;
            ShowHDD.Background = Brushes.DarkGray;
            MotherBoardDescription.Visibility = Visibility.Collapsed;
            MotherBoardImage.Visibility = Visibility.Collapsed;
            MotherBoardPrice.Visibility = Visibility.Collapsed;
            CaseDescription.Visibility = Visibility.Collapsed;
            CaseImage.Visibility = Visibility.Collapsed;
            CasePrice.Visibility = Visibility.Collapsed;
            CPUDescription.Visibility = Visibility.Collapsed;
            CPUImage.Visibility = Visibility.Collapsed;
            CPULinkText.Visibility = Visibility.Collapsed;
            CPUPrice.Visibility = Visibility.Collapsed;
            CaseLinkText.Visibility = Visibility.Collapsed;
            MotherBoardLinkText.Visibility = Visibility.Collapsed;
            GPUDescription.Visibility = Visibility.Collapsed;
            GPULinkText.Visibility = Visibility.Collapsed;
            GPUPrice.Visibility = Visibility.Collapsed;
            RAMDescription.Visibility = Visibility.Collapsed;
            RAMImage.Visibility = Visibility.Collapsed;
            RAMLinkText.Visibility = Visibility.Collapsed;
            RAMPrice.Visibility = Visibility.Collapsed;
            PSUDescription.Visibility = Visibility.Collapsed;
            PSUImage.Visibility = Visibility.Collapsed;
            PSULinkText.Visibility = Visibility.Collapsed;
            PSUPrice.Visibility = Visibility.Collapsed;
            HDDDescription.Visibility = Visibility.Visible;
            HDDImage.Visibility = Visibility.Visible;
            HDDLinkText.Visibility = Visibility.Visible;
            HDDPrice.Visibility = Visibility.Visible;
        }

        private void ShowTotalPrice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("$2594.65");
        }
    }
}
