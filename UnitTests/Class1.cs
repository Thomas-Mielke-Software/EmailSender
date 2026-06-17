using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using System.IO;

namespace UnitTests
{
    // FrmMain hosts a WebBrowser ActiveX control, which only works on an STA
    // thread. NUnit runs tests on an MTA thread by default, so the fixture is
    // pinned to STA here (replaces the old NUnit 2.x Project1.config/.nunit setup).
    [TestFixture, Apartment(ApartmentState.STA)]
    public class Class1
    {
        public Class1()
        {
        }

        [OneTimeTearDown]
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
