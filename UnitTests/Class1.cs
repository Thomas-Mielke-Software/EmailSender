using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace UnitTests
{
    [TestFixture]
    public class Class1
    {
        public Class1()
        {
            //Wow, this is tricky. NUnit GUI by default runs in MTA mode. The WebBrowser control on the form does not like it. In order to run in STA mode, have to create a Project1.config file rest in the same directory with Project1.nunit file.
            //System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA);
        }
        
        [TestFixtureTearDown]
        public void TearDown()
        {
            //Use Task Manager to see if any memory leak.
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private const int _sampleSize = 100000;
        [Test]
        public void TestImportVertical()
        {
            string tempFile = "Sample_Vertical.txt";

            //create test data
            CreateVerticalSampleFile(tempFile);
            
            //do import
            using (EmailSender.FrmMain frm = new EmailSender.FrmMain())
            {
                Assert.AreEqual(_sampleSize, frm.DoVerticalImport(tempFile));

                //verify result
                for (int i = 0; i < _sampleSize; i++)
                {
                    Assert.AreEqual(string.Format("test{0}@test.com", i), frm.uxListViewAddress.Items[i].Text);

                }
            }
        }

        private static void CreateVerticalSampleFile(string tempFile)
        {
            using (TextWriter tw = new StreamWriter(tempFile, false))
            {
                //generate test data.
                for (int i = 0; i < _sampleSize; i++)
                {
                    tw.WriteLine("{0}.Testing Company #{0}", i);
                    tw.WriteLine("Address:  42 Wallaby Way, Sydney");
                    tw.WriteLine("Phone:    +1 604 1234 5678");
                    tw.WriteLine("Fax:  +1 604 1234 5679");
                    tw.WriteLine("E-mail:   test{0}@test.com", i);
                    tw.WriteLine("Website:	www.sherman.com");
                    tw.WriteLine("Contact:	Mr P");
                    tw.WriteLine("Memo:	One line memo");
                    tw.WriteLine();
                }
                tw.Close();
            }
        }


    }
}
