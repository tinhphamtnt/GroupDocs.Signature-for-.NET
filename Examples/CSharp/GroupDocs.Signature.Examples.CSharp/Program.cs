﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Signature.Examples.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Utilities.ApplyLicense();

            #region WorkingWithTextSignature

            //Signatures.SignPdfDocumentWithText("text.pdf");

            //Signatures.SignCellDocumentWithText("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithText("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithText("getting started.docx");

            #endregion

            #region WorkingWithImageSignature

            //Signatures.SignPdfDocumentWithImage("digital signatures.pdf");

            //Signatures.SignCellDocumentWithImage("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithImage("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithImage("getting started.docx");

            #endregion

            #region WorkingWithDigitalSignature

            //Signatures.SignPdfDocumentDigitally("digital signatures.pdf");

            //Signatures.SignCellDocumentDigitally("pie chart.xlsx");

            //Signatures.SignWordDocumentDigitally("getting started.docx");

            //digital signatures are not supported yet for slides documents 
            //Signatures.SignSlideDocumentDigitally("butterfly effect.pptx");

            #endregion

            #region Azure

            //Signatures.CustomInputHandler("digital signatures.pdf");
            //Signatures.CustomOutputHandler("digital signatures.pdf");

            #endregion

            #region GetPasswordProtectedDocs
            //Signatures.GetPasswordProtectedDocs("getting started.docx");
            #endregion

            //Following feature is supported in GroupDocs.Signature for .NET 16.10.0 version or greater
            #region SaveTextSignedFormatOptions

            //Signatures.SignPdfDocumentWithTextWithSaveFormat("digital signatures.pdf");

            //Signatures.SignCellDocumentWithTextWithSaveFormat("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithTextWithSaveFormat("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithTextWithSaveFormat("getting started.docx");

            #endregion

            #region SaveImageSignedFormatOptions

            //Signatures.SignPdfDocumentWithImageWithSaveFormat("digital signatures.pdf");

            //Signatures.SignCellDocumentWithImageWithSaveFormat("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithImageWithSaveFormat("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithImageWithSaveFormat("getting started.docx");

            #endregion

            #region SaveDigitalSignedFormatOptions

            //Signatures.SignPdfDocumentDigitallyWithSaveFormat("digital signatures.pdf");

            //Signatures.SignCellDocumentDigitallyWithSaveFormat("pie chart.xlsx");

            //Signatures.SignWordDocumentDigitallyWithSaveFormat("getting started.docx");

            //digital signatures are not supported yet for slides documents 
            //Signatures.SignSlideDocumentDigitallyWithSaveFormat("butterfly effect.pptx");

            #endregion

            #region SetupMultipleSignatureOptionsInPdf
            //Signatures.MultiplePdfSignOptoins();
            //Signatures.MultipleCellSignOptoins();
            //Signatures.MultipleWordSignOptoins();
            //Signatures.MultipleSlideSignOptoins();
            #endregion

            //Following feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
            #region VerificationOptions
            //Signatures.TextVerificationOfPdfDocument();
            //Signatures.DigitalVerificationOfCellsDocWithCerCertificateContainer();
            //Signatures.DigitalVerificationOfCellsDocWithPfxCertificateContainer();
            //Signatures.DigitalVerificationOfPdfWithCerContainer();
            //Signatures.DigitalVerificationOfPdfWithPfxCertificateContainer();
            //Signatures.DigitalVerificationOfWordDocWithCerCertificateContainer();
            //Signatures.DigitalVerificationOfWordDocWithPfxCertificateContainer();
            #endregion

            //Following feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
            #region SignatureAppearnaceoptions
            //Signatures.SignPdfDocWithTextSignAsImage();
            //Signatures.SignPdfDocWithTextSignAsAnnotation();
            #endregion

            //Signatures.SetOutputFileName();
            Console.ReadKey();
        }
    }
}
