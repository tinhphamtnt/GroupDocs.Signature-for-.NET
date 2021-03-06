﻿Imports GroupDocs.Signature.Options
Imports GroupDocs.Signature.Handler.Output
Imports GroupDocs.Signature.Handler
Imports System.IO
Imports GroupDocs.Signature.Config
Imports GroupDocs.Signature.Handler.Input
Imports GroupDocs.Signature.Domain
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Signatures


#Region "WorkingWithTextSignature"

    ''' <summary>
    ''' Signing a pdf document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignPdfDocumentWithText(fileName As String)
        'ExStart:signingandsavingpdfdocumentwithtext
        Dim size As Single = 100
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options 
        Dim signOptions = New PdfSignTextOptions("coca cola")
        signOptions.Left = 100
        signOptions.Top = 100
        'this feature is supported in 16.12.0
        signOptions.VerticalAlignment = Domain.VerticalAlignment.Top
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 25
        }
        '---------------------------
        signOptions.ForeColor = System.Drawing.Color.Red
        signOptions.BackgroundColor = System.Drawing.Color.Black
        signOptions.Font = New Domain.SignatureFont() With {
            .FontSize = size,
            .FontFamily = "Comic Sans MS"
        }
        Dim fileExtension As String = Path.GetExtension(fileName)
        ' save document
        Utilities.SaveFile(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingpdfdocumentwithtext
    End Sub

    ''' <summary>
    ''' Signing a cell document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input filel</param>
    Public Shared Sub SignCellDocumentWithText(fileName As String)
        'ExStart:signingandsavingcellsdocumentwithtext
        Dim size As Single = 100
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options
        Dim signOptions = New CellsSignTextOptions("coca cola")
        ' text position
        signOptions.RowNumber = 3
        signOptions.ColumnNumber = 6
        ' text rectangle size
        signOptions.Height = 100
        signOptions.Width = 100
        'this feature is supported in 16.12.0
        signOptions.VerticalAlignment = Domain.VerticalAlignment.Top
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 25
        }
        '----------------------------
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = False
        signOptions.ForeColor = System.Drawing.Color.Red
        signOptions.BackgroundColor = System.Drawing.Color.Black
        signOptions.BorderColor = System.Drawing.Color.Green
        signOptions.Font = New Domain.SignatureFont() With {
            .FontSize = size,
            .FontFamily = "Comic Sans MS"
        }
        ' sign first sheet
        signOptions.SheetNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingcellsdocumentwithtext
    End Sub

    ''' <summary>
    ''' Signing a slide document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignSlideDocumentWithText(fileName As String)
        'ExStart:signingandsavingslidesdocumentwithtext
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        Dim size As Single = 100
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options 
        Dim signOptions = New SlidesSignTextOptions("coca cola")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        'this feature is supported in 16.12.0
        signOptions.VerticalAlignment = Domain.VerticalAlignment.Top
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 25
        }
        '----------------------------
        signOptions.ForeColor = System.Drawing.Color.Red
        signOptions.BackgroundColor = System.Drawing.Color.Black
        signOptions.BorderColor = System.Drawing.Color.Green
        signOptions.Font = New Domain.SignatureFont() With {
            .FontSize = size,
            .FontFamily = "Comic Sans MS"
        }
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingslidesdocumentwithtext
    End Sub

    ''' <summary>
    ''' Signing a word document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignWordDocumentWithText(fileName As String)
        'ExStart:signingandsavingworddocumentwithtext
        Dim size As Single = 5
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options
        Dim signOptions = New WordsSignTextOptions("coca cola")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        'this feature is supported in 16.12.0
        signOptions.VerticalAlignment = Domain.VerticalAlignment.Top
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 25
        }
        '----------------------------
        signOptions.ForeColor = System.Drawing.Color.Red
        signOptions.BackgroundColor = System.Drawing.Color.Black
        signOptions.BorderColor = System.Drawing.Color.Green
        signOptions.Font = New Domain.SignatureFont() With {
            .FontSize = size,
            .FontFamily = "Comic Sans MS"
        }
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingworddocumentwithtext
    End Sub

#End Region

#Region "WorkingWithImageSignature"

    ''' <summary>
    ''' Signing a pdf document with image
    ''' </summary>
    ''' <param name="fileName">Name of the input filed</param>
    Public Shared Sub SignPdfDocumentWithImage(fileName As String)
        'ExStart:signingandsavingpdfdocumentwithimage
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New PdfSignImageOptions("sign.png")
        ' image position
        signOptions.Left = 300
        signOptions.Top = 200
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 25
        }
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Left
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingpdfdocumentwithimage
    End Sub

    ''' <summary>
    ''' Signing a cell document with image
    ''' </summary>
    ''' <param name="fileName">Name of the inut file</param>
    Public Shared Sub SignCellDocumentWithImage(fileName As String)
        'ExStart:signingandsavingcelldocumentwithimage
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New CellsSignImageOptions("sign.png")
        ' image position
        signOptions.RowNumber = 10
        signOptions.ColumnNumber = 10
        signOptions.SignAllPages = True
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 8
        }
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingcelldocumentwithimage
    End Sub

    ''' <summary>
    ''' Signing a slide document with image
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignSlideDocumentWithImage(fileName As String)
        'ExStart:signingandsavingslidedocumentwithimage
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New SlidesSignImageOptions("sign.png")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 15
        }
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingslidedocumentwithimage
    End Sub

    ''' <summary>
    ''' Signing word document with image
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignWordDocumentWithImage(fileName As String)
        'ExStart:signingandsavingworddocumentwithimage
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New WordsSignImageOptions("sign.png")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.Margin = New Domain.Padding() With {
            .Top = 2,
            .Left = 500
        }
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Right
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingworddocumentwithimage
    End Sub



    ''' <summary>
    ''' Setting Opacity to Image Signature appearance for Words Documents
    ''' Feature is supported by version 17.03 or greater
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SetOpacityImageSignature(fileName As String)
        'ExStart:SetOpacityImageSignature
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(signConfig)
        'setup size and position
        Dim signOptions As New WordsSignImageOptions("signature.jpg")
        signOptions.Left = 100
        signOptions.Top = 100
        signOptions.Width = 200
        signOptions.Height = 200
        ' setup rotation
        signOptions.RotationAngle = 48
        ' setup opacity
        signOptions.Opacity = 0.28
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
     .OutputType = OutputType.[String],
     .OutputFileName = "Words_Image_Rotation_Opacity"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SetOpacityImageSignature
    End Sub

#End Region

#Region "WorkingWithDigitalSignatures"

    ''' <summary>
    ''' Signing a cell document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignCellDocumentDigitally(fileName As String)

        'ExStart:signingcelldocumentwithdigitalcertificate
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        'Image appearance, opacity and rotation are supported starting from version 17.03
        ' FileStream blocks opened file while it is not disposed so, before 
        ' using .pfx file for another purposes FileStream should be disposed
        Dim certificateStream As Stream = New FileStream("Ali.pfx", FileMode.Open)
        ' setup digital signature options with image appearance
        Dim signOptions As New CellsSignDigitalOptions(certificateStream, "signature.jpg")
        signOptions.Signature.Comments = "Test comment"
        signOptions.Signature.SignTime = New DateTime(2017, 1, 25, 10, 41, 54)
        signOptions.Password = "1234567890"
        ' setup opacity and rotation
        signOptions.Opacity = 0.48
        signOptions.RotationAngle = 45
        'put image signature only on the last page
        signOptions.PagesSetup.LastPage = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
         .OutputType = OutputType.[String],
         .OutputFileName = "SignedForVerification"
        })
        'File stream must be disposed after signing
        certificateStream.Dispose()
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:signingcelldocumentwithdigitalcertificate
    End Sub

    ''' <summary>
    ''' Signing a pdf document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignPdfDocumentDigitally(fileName As String)
        'ExStart:signingpdfdocumentwithdigitalcertificate
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup digital signature options
        Dim signOptions = New PdfSignDigitalOptions("acer.pfx", "sign.png")
        signOptions.Password = Nothing
        ' image position
        signOptions.Left = 100
        signOptions.Top = 100
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.Visible = True
        signOptions.SignAllPages = True
        signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center
        signOptions.VerticalAlignment = Domain.VerticalAlignment.Top
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, Nothing, Nothing, signOptions)
        'ExEnd:signingpdfdocumentwithdigitalcertificate
    End Sub

    ''' <summary>
    ''' Signing a word document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignWordDocumentDigitally(fileName As String)
        'ExStart:signingworddocumentwithdigitalcertificate
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup digital signature options
        Dim signOptions = New WordsSignDigitalOptions("ali.pfx")
        signOptions.Password = ""
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, Nothing, Nothing, signOptions)
        'ExEnd:signingworddocumentwithdigitalcertificate
    End Sub

    ''' <summary>
    ''' Signing a slide document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignSlideDocumentDigitally(fileName As String)
        'ExStart:signingslidedocumentwithdigitalcertificate
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup digital signature options
        Dim signOptions = New SlidesSignDigitalOptions("ali.pfx")
        signOptions.Password = ""
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 2
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, Nothing, Nothing, signOptions)
        'ExEnd:signingslidedocumentwithdigitalcertificate
    End Sub

#End Region

#Region "Azure"

    ''' <summary>
    ''' Custom input handling 
    ''' </summary>
    ''' <param name="inputFileName">Name of the input file</param>
    Public Shared Sub CustomInputHandler(inputFileName As String)
        'ExStart:custominputhandler
        Const DevStorageEmulatorUrl As String = "http://127.0.0.1:10000/devstoreaccount1/"
        Const DevStorageEmulatorAccountName As String = "devstoreaccount1"
        Const DevStorageEmulatorAccountKey As String = "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw=="

        Dim config As SignatureConfig = Utilities.GetConfigurations()

        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)

        Dim saveOptions As New SaveOptions(OutputType.[String])
        Dim customInputStorageProvider As IInputDataHandler = New AzureInputDataHandler(DevStorageEmulatorUrl, DevStorageEmulatorAccountName, DevStorageEmulatorAccountKey, "testbucket")
        Dim handlerWithCustomStorage As New SignatureHandler(config, customInputStorageProvider)

        ' setup image signature options
        Dim signOptions = New PdfSignImageOptions("sign.png")
        signOptions.DocumentPageNumber = 1
        signOptions.Top = 500
        signOptions.Width = 200
        signOptions.Height = 100
        Dim fileExtension As String = Path.GetExtension(inputFileName)
        Utilities.SaveFile(fileExtension, inputFileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:custominputhandler
    End Sub

    ''' <summary>
    ''' Custome output handling
    ''' </summary>
    ''' <param name="inputFileName">Name of the input file</param>
    Public Shared Sub CustomOutputHandler(inputFileName As String)
        'ExStart:customoutputhandler
        Const DevStorageEmulatorUrl As String = "http://127.0.0.1:10000/devstoreaccount1/"
        Const DevStorageEmulatorAccountName As String = "devstoreaccount1"
        Const DevStorageEmulatorAccountKey As String = "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw=="

        Dim config As SignatureConfig = Utilities.GetConfigurations()

        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)

        Dim saveOptions As New SaveOptions(OutputType.[String])
        Dim customOutputStorageProvider As IOutputDataHandler = New AzureOutputDataHandler(DevStorageEmulatorUrl, DevStorageEmulatorAccountName, DevStorageEmulatorAccountKey, "tempbucket")
        Dim handlerWithCustomStorage As New SignatureHandler(config, customOutputStorageProvider)
        ' setup image signature options
        Dim signOptions = New PdfSignImageOptions("sign.png")
        signOptions.DocumentPageNumber = 1
        signOptions.Top = 500
        signOptions.Width = 200
        signOptions.Height = 100
        Dim fileExtension As String = Path.GetExtension(inputFileName)
        Utilities.SaveFile(fileExtension, inputFileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:customoutputhandler
    End Sub

#End Region

#Region "OpenPasswordProtectedDocuments"
    Public Shared Sub GetPasswordProtectedDocs(fileName As String)
        'ExStart:GetPasswordProtectedDocs
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        Dim signOptions = New WordsSignTextOptions("John Smith")
        ' specify load options
        Dim loadOptions As New LoadOptions()
        loadOptions.Password = "1234567890"
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFile(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:GetPasswordProtectedDocs
    End Sub


    ''' <summary>
    ''' Shows how to manipulate password i-e open protected doc,change password etc with SaveOptions
    ''' Feature is supported in version 17.04 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub ManipulatePasswordWithSaveOptions(fileName As String)
        Try
            'ExStart:ManipulatePasswordWithSaveOptions
            ' setup Signature configuration
            Dim config As SignatureConfig = Utilities.GetConfigurations()
            Dim password_1 As String = "1234567890"
            Dim password_2 As String = "0987654321"

            ' instantiating the signature handler
            Dim handler = New SignatureHandler(config)
            ' setup options with text of signature
            Dim signOptions As SignOptions = New CellsSignTextOptions("John Smith")
            ' specify load options
            Dim loadOptions As New LoadOptions()
            ' specify save options
            Dim saveOptions As New SaveOptions() With {
                .OutputType = OutputType.[String]
            }

            'Sign document and save it without password
            'Set signed document name
            saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_WithoutPassword"
            Dim signedDocumentWithoutPassword As String = handler.Sign(Of String)(fileName, signOptions, loadOptions, saveOptions)

            'Since we'll be using the documents created during code execution during next steps, so we'll use the output path in the configurations
            config.StoragePath = Utilities.outputPath
            'Sign document and save it with new password
            'Set signed document name
            saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_NewPassword"
            'Add password to save options
            saveOptions.Password = password_1
            'Sign document with new password
            Dim signedDocumentWithPassword As String = handler.Sign(Of String)(Path.GetFileName(signedDocumentWithoutPassword), signOptions, loadOptions, saveOptions)

            'Sign document and save it with original password
            'Set signed document name
            saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_OriginalPassword"
            'Add password to load options to have ability to open document
            loadOptions.Password = password_1
            'Set saveOptions to use password from loadOptions
            saveOptions.UseOriginalPassword = True
            saveOptions.Password = [String].Empty
            'Sign document with original password
            Dim signedDocumentWithOriginalPassword As String = handler.Sign(Of String)(Path.GetFileName(signedDocumentWithPassword), signOptions, loadOptions, saveOptions)

            'Sign document and save it with another password
            'Set signed document name
            saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_AnotherPassword"
            'Add password to load options to have ability to open document
            loadOptions.Password = password_1
            'Set saveOptions to use another password
            saveOptions.UseOriginalPassword = False
            saveOptions.Password = password_2
            'Sign document with another password
            Dim signedDocumentWithAnotherPassword As String = handler.Sign(Of String)(Path.GetFileName(signedDocumentWithOriginalPassword), signOptions, loadOptions, saveOptions)

            'Sign document and save it without password
            'Set signed document name
            saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_RemovedPassword"
            'Add password to load options to have ability to open document
            loadOptions.Password = password_2
            'Set saveOptions with empty password
            saveOptions.UseOriginalPassword = False
            saveOptions.Password = [String].Empty
            'Sign document with removed password
            Dim signedDocumentWithRemovedPassword As String = handler.Sign(Of String)(Path.GetFileName(signedDocumentWithAnotherPassword), signOptions, loadOptions, saveOptions)
        Catch ex As System.Exception
            Console.WriteLine("ERROR processing the examples." & vbLf & vbLf + ex.Message)
        End Try
        'ExEnd:ManipulatePasswordWithSaveOptions
    End Sub

#End Region

#Region "SaveTextSignedOutputWithFormatOptions"

    ''' <summary>
    ''' Signing a pdf document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignPdfDocumentWithTextWithSaveFormat(fileName As String)
        'ExStart:signingandsavingpdfdocumentwithtext
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options 
        Dim signOptions = New PdfSignTextOptions("coca cola")
        signOptions.Left = 100
        signOptions.Top = 100
        Dim fileExtension As String = Path.GetExtension(fileName)
        ' save document
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingpdfdocumentwithtext
    End Sub

    ''' <summary>
    ''' Signing a cell document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input filel</param>
    Public Shared Sub SignCellDocumentWithTextWithSaveFormat(fileName As String)
        'ExStart:signingandsavingcellsdocumentwithtext
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options
        Dim signOptions = New CellsSignTextOptions("coca cola")
        ' text position
        signOptions.RowNumber = 3
        signOptions.ColumnNumber = 6
        ' text rectangle size
        signOptions.Height = 100
        signOptions.Width = 100
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = False
        ' sign first sheet
        signOptions.SheetNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingcellsdocumentwithtext
    End Sub

    ''' <summary>
    ''' Signing a slide document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignSlideDocumentWithTextWithSaveFormat(fileName As String)
        'ExStart:signingandsavingslidesdocumentwithtext
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options 
        Dim signOptions = New SlidesSignTextOptions("coca cola")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingslidesdocumentwithtext
    End Sub

    ''' <summary>
    ''' Signing a word document with text
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignWordDocumentWithTextWithSaveFormat(fileName As String)
        'ExStart:signingandsavingworddocumentwithtext
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup text signature options
        Dim signOptions = New WordsSignTextOptions("coca cola")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, Nothing, Nothing)
        'ExEnd:signingandsavingworddocumentwithtext
    End Sub


#End Region

#Region "SaveImageSignedOutputWithFormatOptions"

    ''' <summary>
    ''' Signing a pdf document with image
    ''' </summary>
    ''' <param name="fileName">Name of the input filed</param>
    Public Shared Sub SignPdfDocumentWithImageWithSaveFormat(fileName As String)
        'ExStart:signingandsavingpdfdocumentwithimageWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New PdfSignImageOptions("sign.png")
        ' image position
        signOptions.Left = 300
        signOptions.Top = 200
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingpdfdocumentwithimageWithSaveFormat
    End Sub

    ''' <summary>
    ''' Signing a cell document with image
    ''' </summary>
    ''' <param name="fileName">Name of the inut file</param>
    Public Shared Sub SignCellDocumentWithImageWithSaveFormat(fileName As String)
        'ExStart:signingandsavingcelldocumentwithimageWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New CellsSignImageOptions("sign.png")
        ' image position
        signOptions.RowNumber = 10
        signOptions.ColumnNumber = 10
        signOptions.SignAllPages = True
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingcelldocumentwithimageWithSaveFormat
    End Sub

    ''' <summary>
    ''' Signing a slide document with image
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignSlideDocumentWithImageWithSaveFormat(fileName As String)
        'ExStart:signingandsavingslidedocumentwithimageWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New SlidesSignImageOptions("sign.png")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingslidedocumentwithimageWithSaveFormat
    End Sub

    ''' <summary>
    ''' Signing word document with image
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignWordDocumentWithImageWithSaveFormat(fileName As String)
        'ExStart:signingandsavingworddocumentwithimageWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup image signature options
        Dim signOptions = New WordsSignImageOptions("sign.png")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, signOptions, Nothing)
        'ExEnd:signingandsavingworddocumentwithimageWithSaveFormat
    End Sub

#End Region

#Region "SaveDigitalSignedOutputWithFormatOptions"

    ''' <summary>
    ''' Signing a cell document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignCellDocumentDigitallyWithSaveFormat(fileName As String)
        'ExStart:signingcelldocumentwithdigitalcertificateWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup digital signature options
        Dim signOptions = New CellsSignDigitalOptions("ali.pfx")
        signOptions.Password = ""
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, Nothing, signOptions)
        'ExEnd:signingcelldocumentwithdigitalcertificateWithSaveFormat
    End Sub

    ''' <summary>
    ''' Signing a pdf document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignPdfDocumentDigitallyWithSaveFormat(fileName As String)
        'ExStart:signingpdfdocumentwithdigitalcertificateWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup digital signature options
        Dim signOptions = New PdfSignDigitalOptions("acer.pfx", "sign.png")
        signOptions.Password = Nothing
        ' image position
        signOptions.Left = 100
        signOptions.Top = 100
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, Nothing, signOptions)
        'ExEnd:signingpdfdocumentwithdigitalcertificateWithSaveFormat
    End Sub

    ''' <summary>
    ''' Signing a word document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignWordDocumentDigitallyWithSaveFormat(fileName As String)
        'ExStart:signingworddocumentwithdigitalcertificateWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup digital signature options
        Dim signOptions = New WordsSignDigitalOptions("ali.pfx")
        signOptions.Password = ""
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 1
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, Nothing, signOptions)
        'ExEnd:signingworddocumentwithdigitalcertificateWithSaveFormat
    End Sub

    ''' <summary>
    ''' Signing a slide document with digital certificate
    ''' </summary>
    ''' <param name="fileName">Name of the input file</param>
    Public Shared Sub SignSlideDocumentDigitallyWithSaveFormat(fileName As String)
        'ExStart:signingslidedocumentwithdigitalcertificateWithSaveFormat
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' setup digital signature options
        Dim signOptions = New SlidesSignDigitalOptions("ali.pfx")
        signOptions.Password = ""
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.Width = 100
        signOptions.Height = 100
        signOptions.DocumentPageNumber = 2
        Dim fileExtension As String = Path.GetExtension(fileName)
        Utilities.SaveFileWithFormat(fileExtension, fileName, handler, Nothing, Nothing, signOptions)
        'ExEnd:signingslidedocumentwithdigitalcertificateWithSaveFormat
    End Sub

#End Region

#Region "SetupMultipleSignatureOptions"
    'Multiple sign options Pdf documents 
    Public Shared Sub MultiplePdfSignOptoins()
        'ExStart:multiplepdfsignoptions
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' define Signature Options Collection
        Dim collection = New SignatureOptionsCollection()
        ' specify text option
        Dim signTextOptions = New PdfSignTextOptions("Mr. John", 100, 100, 100, 100)
        ' add to collection
        collection.Add(signTextOptions)
        ' specify image options
        Dim signImageOptions = New PdfSignImageOptions("sign.png")
        signImageOptions.Left = 200
        signImageOptions.Top = 200
        signImageOptions.Width = 100
        signImageOptions.Height = 100
        ' add to collection
        collection.Add(signImageOptions)
        ' specify digital options
        Dim signDigitalOptions = New PdfSignDigitalOptions("acer.pfx")
        signDigitalOptions.Password = "1234567890"
        signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom
        signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center
        ' add to collection
        collection.Add(signDigitalOptions)
        ' sign document
        Dim signedPath = handler.Sign(Of String)("test.pdf", collection, New SaveOptions() With {
            .OutputType = OutputType.[String]
        })
        Console.WriteLine("Signed file path is: " + signedPath)
        'ExEnd:multiplepdfsignoptions
    End Sub

    'Multiple sign options Cells
    Public Shared Sub MultipleCellSignOptoins()
        'ExStart:MultipleCellSignOptoins
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' define Signature Options Collection
        Dim collection = New SignatureOptionsCollection()
        ' specify text option
        Dim signTextOptions = New CellsSignTextOptions("some person")
        ' add to collection
        collection.Add(signTextOptions)
        ' specify image options
        Dim signImageOptions = New CellsSignImageOptions("sign.png")
        signImageOptions.Left = 200
        signImageOptions.Top = 200
        signImageOptions.Width = 100
        signImageOptions.Height = 100
        ' add to collection
        collection.Add(signImageOptions)
        ' specify digital options
        Dim signDigitalOptions = New CellsSignDigitalOptions("acer.pfx")
        signDigitalOptions.Password = "1234567890"
        signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom
        signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center
        ' add to collection
        collection.Add(signDigitalOptions)
        ' sign document
        Dim signedPath = handler.Sign(Of String)("test.xlsx", collection, New SaveOptions() With {
            .OutputType = OutputType.[String]
        })
        Console.WriteLine("Signed file path is: " + signedPath)
        'ExEnd:MultipleCellSignOptoins
    End Sub
    'Multiple sign options Word
    Public Shared Sub MultipleWordSignOptoins()
        'ExStart:MultipleWordSignOptoins
        Dim config As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the signature handler
        Dim handler = New SignatureHandler(config)
        ' define Signature Options Collection
        Dim collection = New SignatureOptionsCollection()
        ' specify text option
        Dim signTextOptions = New WordsSignTextOptions("some person")
        ' add to collection
        collection.Add(signTextOptions)
        ' specify image options
        Dim signImageOptions = New WordsSignImageOptions("sign.png")
        signImageOptions.Left = 200
        signImageOptions.Top = 200
        signImageOptions.Width = 100
        signImageOptions.Height = 100
        ' add to collection
        collection.Add(signImageOptions)
        ' specify digital options
        Dim signDigitalOptions = New WordsSignDigitalOptions("acer.pfx")
        signDigitalOptions.Password = "1234567890"
        signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom
        signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center
        ' add to collection
        collection.Add(signDigitalOptions)
        ' sign document
        Dim signedPath = handler.Sign(Of String)("test.docx", collection, New SaveOptions() With {
            .OutputType = OutputType.[String]
        })
        Console.WriteLine("Signed file path is: " + signedPath)
        'ExEnd:MultipleWordSignOptoins
    End Sub


    ''Multiple sign options slides
    'Public Shared Sub MultipleSlideSignOptoins()
    '    'ExStart:multipleslidesignoptions
    '    Dim config As SignatureConfig = Utilities.GetConfigurations()
    '    ' instantiating the signature handler
    '    Dim handler = New SignatureHandler(config)
    '    ' define Signature Options Collection
    '    Dim collection = New SignatureOptionsCollection()
    '    ' specify text option
    '    Dim signTextOptions = New SlideSignTextOptions("Mr. John", 100, 100, 100, 100)
    '    ' add to collection
    '    collection.Add(signTextOptions)
    '    ' specify image options
    '    Dim signImageOptions = New SlideSignImageOptions("sign.png")
    '    signImageOptions.Left = 200
    '    signImageOptions.Top = 200
    '    signImageOptions.Width = 100
    '    signImageOptions.Height = 100
    '    ' add to collection
    '    collection.Add(signImageOptions)
    '    ' specify digital options
    '    Dim signDigitalOptions = New SlideSignDigitalOptions("acer.pfx")
    '    signDigitalOptions.Password = "1234567890"
    '    signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom
    '    signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center
    '    ' add to collection
    '    collection.Add(signDigitalOptions)
    '    ' sign document
    '    Dim signedPath = handler.Sign(Of String)("butterfly effect.pptx", collection, New SaveOptions() With { _
    '        .OutputType = OutputType.[String] _
    '    })
    '    Console.WriteLine("Signed file path is: " + signedPath)
    '    'ExEnd:multipleslidesignoptions
    'End Sub

#End Region


#Region "SignatureAppearanceOptions"

    ''' <summary>
    ''' Signs Pdf document with Text Signature as Image
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub SignPdfDocWithTextSignAsImage(fileName As String)
        'ExStart:SignPdfDocWithTextSignAsImage
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup image signature options with relative path - image file stores in config.ImagesPath folder
        Dim signOptions As New PdfSignTextOptions("John Smith")
        ' setup colors settings
        signOptions.BackgroundColor = System.Drawing.Color.Beige
        ' setup text color
        signOptions.ForeColor = System.Drawing.Color.Red
        ' setup Font options
        signOptions.Font.Bold = True
        signOptions.Font.Italic = True
        signOptions.Font.Underline = True
        signOptions.Font.FontFamily = "Arial"
        signOptions.Font.FontSize = 15
        'type of implementation
        signOptions.SignatureImplementation = PdfTextSignatureImplementation.Image
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_TextSignatureAsImage"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignPdfDocWithTextSignAsImage
    End Sub

    ''' <summary>
    ''' Signs Pdf document with Text Signature as Annotation
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub SignPdfDocWithTextSignAsAnnotation(fileName As String)
        'ExStart:SignPdfDocWithTextSignAsAnnotation
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup image signature options with relative path - image file stores in config.ImagesPath folder
        Dim signOptions As New PdfSignTextOptions("John Smith")
        signOptions.Left = 100
        signOptions.Top = 100
        signOptions.Height = 200
        signOptions.Width = 200
        ' setup colors settings
        signOptions.BackgroundColor = System.Drawing.Color.Beige
        ' setup text color
        signOptions.ForeColor = System.Drawing.Color.Red
        ' setup Font options
        signOptions.Font.Bold = True
        signOptions.Font.Italic = True
        signOptions.Font.Underline = True
        signOptions.Font.FontFamily = "Arial"
        signOptions.Font.FontSize = 15
        'type of implementation
        signOptions.SignatureImplementation = PdfTextSignatureImplementation.Annotation
        ' specify extended appearance options
        Dim appearance As New PdfTextAnnotationAppearance()
        appearance.BorderColor = Color.Blue
        appearance.BorderEffect = PdfTextAnnotationBorderEffect.Cloudy
        appearance.BorderEffectIntensity = 2
        appearance.BorderStyle = PdfTextAnnotationBorderStyle.Dashed
        appearance.HCornerRadius = 10
        appearance.BorderWidth = 5
        appearance.Contents = signOptions.Text + " content description"
        appearance.Subject = "Appearance Subject"
        appearance.Title = "MrJohn Signature"
        signOptions.Appearance = appearance
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_TextSignatureAsAnnotation"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignPdfDocWithTextSignAsAnnotation
    End Sub

    ''' <summary>
    ''' Signs Pdf document with Text Signature as Sticker
    ''' This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
    ''' </summary>
    Public Shared Sub SignPdfDocWithTextSignatureAsSticker(fileName As String)
        'ExStart:SignPdfDocWithTextSignatureAsSticker
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup signature options
        Dim signOptions As New PdfSignTextOptions("John Smith")
        signOptions.Left = 10
        signOptions.Top = 10
        signOptions.HorizontalAlignment = HorizontalAlignment.Right
        signOptions.VerticalAlignment = VerticalAlignment.Bottom
        signOptions.Margin = New Padding(10)
        signOptions.BackgroundColor = Color.Red
        signOptions.Opacity = 0.5
        'type of implementation
        signOptions.SignatureImplementation = PdfTextSignatureImplementation.Sticker
        ' an appearance customizes more specific options
        Dim appearance As New PdfTextStickerAppearance()
        signOptions.Appearance = appearance
        ' text content of an sticker
        appearance.Title = "Title"
        appearance.Subject = "Subject"
        appearance.Contents = "Contents"
        ' is sticker opened by default
        appearance.Opened = False
        ' an icon of a sticker on a page
        appearance.Icon = PdfTextStickerIcon.Star
        'If custom appearance is not set there will be used DefaultAppearance
        'User can change any parameter of DefaultAppearance
        'PdfTextStickerAppearance.DefaultAppearance.Title = "Title";
        'PdfTextStickerAppearance.DefaultAppearance.Subject = "Subject";
        'PdfTextStickerAppearance.DefaultAppearance.Contents = "Contents";
        'PdfTextStickerAppearance.DefaultAppearance.Opened = false;
        'PdfTextStickerAppearance.DefaultAppearance.State = PdfTextStickerState.Completed;
        'PdfTextStickerAppearance.DefaultAppearance.Icon = PdfTextStickerIcon.Note;
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_TextSignatureAsSticker"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignPdfDocWithTextSignatureAsSticker
    End Sub

    ''' <summary>
    ''' Adds Rotation to Text Signature appearance
    ''' This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
    ''' </summary>
    Public Shared Sub AddRotationToTextSignatureAppearance(fileName As String)
        'ExStart:AddRotationToTextSignatureAppearance
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup appearance options
        Dim signOptions As New PdfSignTextOptions("John Smith")
        signOptions.Font.FontSize = 32
        signOptions.BackgroundColor = Color.BlueViolet
        signOptions.ForeColor = Color.Orange
        signOptions.Left = 200
        signOptions.Top = 200
        ' setup rotation
        signOptions.RotationAngle = 48
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_Text_Rotation"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:AddRotationToTextSignatureAppearance
    End Sub

    ''' <summary>
    ''' Adds Transparency and Rotation to Text Signature appearance for Slides
    ''' This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
    ''' </summary>
    Public Shared Sub AddTransparencyRotationToTextSignatureForSlides(fileName As String)
        'ExStart:AddTransparencyRotationToTextSignatureForSlides
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup appearance options
        Dim signOptions As New SlidesSignTextOptions("John Smith")
        signOptions.Left = 100
        signOptions.Top = 100
        signOptions.Width = 200
        signOptions.Height = 200
        signOptions.ForeColor = Color.Orange
        signOptions.BackgroundColor = Color.BlueViolet
        signOptions.BorderColor = Color.Orange
        signOptions.BorderWeight = 5
        ' setup rotation
        signOptions.RotationAngle = 48
        ' setup transparency
        signOptions.BackgroundTransparency = 0.4
        signOptions.BorderTransparency = 0.8
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Slides_Text_Transparency_Rotation"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd: AddTransparencyRotationToTextSignatureForSlides
    End Sub

    ''' <summary>
    ''' Adds Rotation to Image Signature appearance
    ''' This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
    ''' </summary>
    Public Shared Sub AddRotationToImageSignatureAppearance(fileName As String)
        'ExStart:AddRotationToImageSignatureAppearance
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        'setup size and position
        Dim signOptions As New PdfSignImageOptions("signature.jpg")
        signOptions.Left = 100
        signOptions.Top = 100
        signOptions.Width = 200
        signOptions.Height = 200
        ' setup rotation
        signOptions.RotationAngle = 48
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_Image_Rotation"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:AddRotationToImageSignatureAppearance
    End Sub



    ''' <summary>
    ''' Shows how to add extended options to Image Signature appearance
    ''' This feature is suppored in version 17.04 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub ImageSignatureAppearanceExtendedoptions(fileName As String)
        'ExStart:ImageSignatureAppearanceExtendedoptions
        Try
            ' setup Signature configuration
            Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
            ' instantiating the conversion handler
            Dim handler As New SignatureHandler(signConfig)
            'setup size and position
            Dim signOptions As New WordsSignImageOptions("signature.jpg")
            signOptions.Left = 100
            signOptions.Top = 100
            signOptions.Width = 200
            signOptions.Height = 200
            ' setup rotation
            signOptions.RotationAngle = 48
            ' setup opacity
            signOptions.Opacity = 0.88
            'setup additional image appearance
            Dim imageAppearance As New ImageAppearance()
            imageAppearance.Brightness = 1.2F
            imageAppearance.Grayscale = True
            imageAppearance.BorderDashStyle = ExtendedDashStyle.Dot
            imageAppearance.BorderColor = System.Drawing.Color.OrangeRed
            imageAppearance.BorderWeight = 5
            signOptions.Appearance = imageAppearance

            ' sign document
            Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
                .OutputType = OutputType.[String],
                .OutputFileName = "Words_Image_Rotation_Opacity"
            })
            Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        Catch ex As System.Exception
            Console.WriteLine(ex.Message)
        End Try
        'ExEnd:ImageSignatureAppearanceExtendedoptions
    End Sub


    ''' <summary>
    ''' Specification of arbitrary pages of Document for processing signature or verification
    ''' Feature is supported in version 17.03 or greater
    ''' </summary>
    Public Shared Sub SignArbitraryPages(fileName As String)
        'ExStart:SignArbitraryPages
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options of signature
        Dim signOptions As New PdfSignImageOptions("signature.jpg")
        ' setup image size
        signOptions.Width = 100
        signOptions.Height = 100
        ' setup pages to sign
        signOptions.PagesSetup.FirstPage = True
        signOptions.PagesSetup.EvenPages = True
        signOptions.PagesSetup.PageNumbers.Add(1)
        signOptions.PagesSetup.LastPage = False
        ' specify load options
        Dim loadOptions As New LoadOptions()
        ' specify save options
        Dim saveOptions As New CellsSaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "ArbitraryPagesOfDocument"
        }
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, loadOptions, saveOptions)
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignArbitraryPages
    End Sub


    ''' <summary>
    ''' Shows how to sign PDF documents with text signature as watermark
    ''' Feature is supporyted by version 17.05 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignPDFDocsWithTextSignatureAsWatermark(fileName As String)
        'ExStart:SignPDFDocsWithTextSignatureAsWatermark
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup text signature options
        Dim signOptions As New PdfSignTextOptions("John Smith")
        'type of implementation
        signOptions.SignatureImplementation = PdfTextSignatureImplementation.Watermark
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_TextSignatureWatermark"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignPDFDocsWithTextSignatureAsWatermark
    End Sub

    ''' <summary>
    ''' Shows how to specify different Measure Unit Types for PDF Text Signature
    ''' Feature is supporyted by version 17.05 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SpecifyDifferentMeasureUnitsForPDFTextSignature(fileName As String)
        'ExStart:SpecifyDifferentMeasureUnitsForPDFTextSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)

        ' setup text signature options and try locate signature at top right corner
        Dim signOptions As New PdfSignTextOptions("John Smith")
        signOptions.ForeColor = Color.Red
        'setup text position on a page in 5 centimeters from top 
        signOptions.LocationMeasureType = MeasureType.Millimeters
        signOptions.Top = 50
        'setup signature area size in pixels
        signOptions.SizeMeasureType = MeasureType.Pixels
        signOptions.Width = 200
        signOptions.Height = 100
        'setup signature margins and horizontal alignment
        signOptions.HorizontalAlignment = HorizontalAlignment.Right
        signOptions.MarginMeasureType = MeasureType.Percents
        signOptions.Margin.Right = 10
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "DifferentMeasureUnitTypes"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SpecifyDifferentMeasureUnitsForPDFTextSignature
    End Sub

    ''' <summary>
    ''' Shows how to sign Words Documents with Text Signature to form text field
    ''' Feature is supporyted by version 17.05 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignWordsDocsWithTextSignToFormTextField(fileName As String)
        'ExStart:SignWordsDocsWithTextSignToFormTextField
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup text signature options
        Dim signOptions As New WordsSignTextOptions("John Smith")
        signOptions.SignatureImplementation = WordsTextSignatureImplementation.TextToFormField
        signOptions.FormTextFieldType = WordsFormTextFieldType.RichText
        signOptions.FormTextFieldTitle = "RT"
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Words_FormFields"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignWordsDocsWithTextSignToFormTextField
    End Sub



#End Region
#Region "SetVerificationOptions"

    ''' <summary>
    ''' Verifies PDF Documents signed with Text Signature 
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub TextVerificationOfPdfDocument(fileName As String)
        'ExStart:TextVerificationOfPdfDocument
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        Dim text As [String] = "John Smith, esquire"
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup image signature options with relative path - image file stores in config.ImagesPath folder
        Dim signOptions As New PdfSignTextOptions(text)
        signOptions.Left = 100
        signOptions.Top = 100
        signOptions.DocumentPageNumber = 1
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_Documents_Verification_Text"
        })
        ' setup digital verification options
        Dim verifyOptions As New PDFVerifyTextOptions(text)
        verifyOptions.DocumentPageNumber = 1

        'verify document
        Dim result As VerificationResult = handler.Verify(signedPath, verifyOptions)
        Console.WriteLine("Verification result: " + result.IsValid)
        'ExEnd:TextVerificationOfPdfDocument
    End Sub

    ''' <summary>
    ''' Verifies Cells Documents signed with .cer digital certificates 
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub DigitalVerificationOfCellsDocWithCerCertificateContainer(fileName As String)
        'ExStart:DigitalVerificationOfCellsDocWithCertificateContainer
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions As New CellsVerifyDigitalOptions("signtest.cer")
        verifyOptions.Comments = "Test1"
        verifyOptions.SignDateTimeFrom = New DateTime(2017, 1, 26, 14, 55, 7)
        verifyOptions.SignDateTimeTo = New DateTime(2017, 1, 26, 14, 55, 9)

        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:DigitalVerificationOfCellsDocWithCertificateContainer
    End Sub

    ''' <summary>
    ''' Digitally verifies cells document with .pfx certificate container
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub DigitalVerificationOfCellsDocWithPfxCertificateContainer(fileName As String)
        'ExStart:DigitalVerificationOfCellsDocWithPfxCertificateContainer
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions1 As New CellsVerifyDigitalOptions("signtest.pfx")
        'password is needed to open .pfx certificate
        verifyOptions1.Password = "123"
        Dim verifyOptions2 As New CellsVerifyDigitalOptions("signtest.cer")
        Dim verifyOptionsCollection As New VerifyOptionsCollection(New List(Of VerifyOptions)() From {
            verifyOptions1,
            verifyOptions2
        })

        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptionsCollection)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:DigitalVerificationOfCellsDocWithPfxCertificateContainer
    End Sub

    ''' <summary>
    ''' Verifies pdf Documents signed with .cer digital certificates 
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub DigitalVerificationOfPdfWithCerContainer(fileName As String)
        'ExStart:DigitalVerificationOfPdfWithCertificateContainer
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions As New PDFVerifyDigitalOptions("ali.cer")
        verifyOptions.Reason = "Test reason"
        verifyOptions.Contact = "Test contact"
        verifyOptions.Location = "Test location"
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:DigitalVerificationOfPdfWithCertificateContainer
    End Sub


    ''' <summary>
    ''' Digitally verifies pdf document with .pfx certificate container
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub DigitalVerificationOfPdfWithPfxCertificateContainer(fileName As String)
        'ExStart:DigitalVerificationOfPdfWithPfxCertificateContainer
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions1 As New PDFVerifyDigitalOptions("ali.pfx")
        'password is needed to open .pfx certificate
        verifyOptions1.Password = "1234567890"
        Dim verifyOptions2 As New PDFVerifyDigitalOptions("ali.cer")
        Dim verifyOptionsCollection As New VerifyOptionsCollection(New List(Of VerifyOptions)() From {
            verifyOptions1,
            verifyOptions2
        })
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptionsCollection)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:DigitalVerificationOfPdfWithPfxCertificateContainer
    End Sub

    ''' <summary>
    ''' Verifies word Documents signed with .cer digital certificates 
    ''' </summary>
    Public Shared Sub DigitalVerificationOfWordDocWithCerCertificateContainer(fileName As String)
        'ExStart:DigitalVerificationOfWordDocWithCertificateContainer
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)

        Dim verifyOptionsCollection As New VerifyOptionsCollection()
        ' setup digital verification options
        Dim verifyOptions As New WordsVerifyDigitalOptions("signtest.cer")
        verifyOptions.Comments = "Test1"
        verifyOptions.SignDateTimeFrom = New DateTime(2017, 1, 26, 14, 55, 57)
        verifyOptions.SignDateTimeTo = New DateTime(2017, 1, 26, 14, 55, 59)
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:DigitalVerificationOfWordDocWithCertificateContainer
    End Sub


    ''' <summary>
    ''' Digitally verifies word document with .pfx certificate container
    ''' This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
    ''' </summary>
    Public Shared Sub DigitalVerificationOfWordDocWithPfxCertificateContainer(fileName As String)
        'ExStart:DigitalVerificationOfWordDocWithPfxCertificateContainer
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions1 As New WordsVerifyDigitalOptions("signtest.pfx")
        'password is needed to open .pfx certificate
        verifyOptions1.Password = "123"
        Dim verifyOptions2 As New WordsVerifyDigitalOptions("signtest.cer")
        Dim verifyOptionsCollection As New VerifyOptionsCollection(New List(Of VerifyOptions)() From {
            verifyOptions1,
            verifyOptions2
        })
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptionsCollection)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:DigitalVerificationOfWordDocWithPfxCertificateContainer
    End Sub

    ''' <summary>
    ''' Verifies PDF Document signed with Text Signature Sticker
    ''' This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
    ''' </summary>
    Public Shared Sub VerifyPdfDocumentSignedWithTextSignatureSticker(fileName As String)
        'ExStart:VerifyPdfDocumentSignedWithTextSignatureSticker
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New PDFVerifyTextOptions()
        ' specify verification type
        verifyOptions.SignatureImplementation = PdfTextSignatureImplementation.Sticker
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "Contents"
        ' create Verify Extensions
        Dim extensions As New PdfTextStickerVerifyExtensions()
        'If verify option is set, then appropriate property of Sticker must be equals
        extensions.Contents = "Contents"
        extensions.Subject = "Subject"
        extensions.Title = "Title"
        extensions.Icon = PdfTextStickerIcon.Cross
        ' set extensions to verification options
        verifyOptions.Extensions = extensions
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyPdfDocumentSignedWithTextSignatureSticker
    End Sub

    ''' <summary>
    ''' Verifies PDF Document signed with Text Signature Annotation
    ''' This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
    ''' </summary>
    Public Shared Sub VerifyPdfDocumentSignedWithTextSignatureAnnotation(fileName As String)
        'ExStart:VerifyPdfDocumentSignedWithTextSignatureAnnotation
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New PDFVerifyTextOptions()
        ' specify verification type
        verifyOptions.SignatureImplementation = PdfTextSignatureImplementation.Annotation
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "John Smith_1"
        ' create Verify Extensions
        Dim extensions As New PdfTextAnnotationVerifyExtensions()
        'If verify option is set, then appropriate property of Annotation must be equals
        extensions.Contents = "John Smith_1"
        extensions.Subject = "John Smith_2"
        extensions.Title = "John Smith_3"
        ' set extensions to verification options
        verifyOptions.Extensions = extensions
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyPdfDocumentSignedWithTextSignatureAnnotation
    End Sub

    ''' <summary>
    ''' Verification of Cells Document signed with Text Signature
    ''' Feature is supported in version 17.03 or greater
    ''' </summary>
    Public Shared Sub VerifyCellDocumentSignedWithTextSignature(fileName As String)
        'ExStart:VerifyCellDocumentSignedWithTextSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions As New CellsVerifyTextOptions("John Smith")
        verifyOptions.PagesSetup.LastPage = True
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:VerifyCellDocumentSignedWithTextSignature
    End Sub

    ''' <summary>
    ''' Verification of Words Document signed with Text Signature
    ''' Feature is supported in version 17.03 or greater
    ''' </summary>
    Public Shared Sub VerifyWordDocumentSignedWithTextSignature(fileName As String)
        'ExStart:VerifyWordDocumentSignedWithTextSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions As New WordsVerifyTextOptions("John Smith")
        verifyOptions.PagesSetup.FirstPage = True
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:VerifyWordDocumentSignedWithTextSignature
    End Sub

    ''' <summary>
    ''' Verification of Slides Document signed with Text Signature
    ''' Feature is supported in version 17.03 or greater
    ''' </summary>
    Public Shared Sub VerifySlidesDocumentSignedWithTextSignature(fileName As String)
        'ExStart:VerifySlidesDocumentSignedWithTextSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions As New SlidesVerifyTextOptions("John Smith")
        verifyOptions.PagesSetup.FirstPage = True
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:VerifySlidesDocumentSignedWithTextSignature
    End Sub


    ''' <summary>
    ''' Shows how to Verify Words Document signed with Text Signature to form text field
    ''' Feature is supported in version 17.05 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub VerifyWordsDocWithTextSignatureToFormTextField(fileName As String)
        'ExStart:VerifyWordsDocWithTextSignatureToFormTextField
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup digital verification options
        Dim verifyOptions As New WordsVerifyTextOptions()
        ' specify other options
        ' text
        verifyOptions.Text = "John Smith"
        ' type of text field
        verifyOptions.FormTextFieldType = WordsFormTextFieldType.AllTextTypes
        ' title of text field
        verifyOptions.FormTextFieldTitle = "RT"
        'verify document
        Dim result As VerificationResult = handler.Verify(fileName, verifyOptions)
        Console.WriteLine("Signed file verification result: " + result.IsValid)
        'ExEnd:VerifyWordsDocWithTextSignatureToFormTextField
    End Sub



#End Region



    ''' <summary>
    ''' OUtput file name can be set in saveoptions
    ''' </summary>
    Public Shared Sub SetOutputFileName()
        'ExStart:SetOutputFileName
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As SignOptions = New CellsSignTextOptions("John Smith")
        ' specify load options
        Dim loadOptions As New LoadOptions()
        ' specify save options
        Dim saveOptions As New CellsSaveOptions() With {
        .OutputType = OutputType.[String],
        .OutputFileName = "FileWithDifferentFileName"
        }
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)("pie chart.xlsx", signOptions, loadOptions, saveOptions)
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SetOutputFileName
    End Sub


    ''' <summary>
    ''' Shows how to obtain information about documents
    ''' Feature is supported in version 17.05 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub GetDocumentInfo(fileName As String)
        'ExStart:GetDocumentInfo
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' Document description
        Dim docInfo As DocumentDescription = handler.GetDocumentDescription(fileName)
        Console.WriteLine("Document " + docInfo.Guid + " contains " + docInfo.PageCount + " pages")
        Console.WriteLine("Width of first page is " + docInfo.Pages.FirstOrDefault().Width)
        ' Image from specified page
        Dim bytesImage As Byte() = handler.GetPageImage(fileName, 1)
        Dim memoryStream As New MemoryStream(bytesImage)
        Using image__1 As Image = Image.FromStream(memoryStream)
            ' Make something with image   
            Console.WriteLine("Height of image is " + image__1.Height)
            image__1.Save("c:\Aspose\Test\Output\ImageFromPage.png", ImageFormat.Png)
        End Using
        memoryStream.Dispose()
        ' Page size
        Dim pageSize As Size = handler.GetDocumentPageSize("c:\Aspose\Test\Storage\test.pdf", 1)
        Console.WriteLine("Page size is " + pageSize.Height + " x " + pageSize.Width)
        'ExEnd:GetDocumentInfo
    End Sub



#Region "working with barcode signatures"
    ''' <summary>
    ''' Shows how to use bar code types in sign options
    ''' Feature is supported in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub UsingBarCodeTypes(fileName As String)
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        'ExStart:UsingBarCodeTypes
        ' setup text signature options
        Dim signOptions = New PdfBarcodeSignOptions()
        ' barcode type
        signOptions.EncodeType = BarcodeTypes.EAN14
        ' signature text
        signOptions.Text = "12345678901234"
        ' text position
        signOptions.HorizontalAlignment = HorizontalAlignment.Right
        signOptions.VerticalAlignment = VerticalAlignment.Bottom
        'ExEnd:UsingBarCodeTypes
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "BarCode_Document"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
    End Sub

    ''' <summary>
    ''' Shows how to sign cells document with barcode options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignCellsDocumentWithBarCodeOptions(fileName As String)
        'ExStart:SignCellsDocumentWithBarCodeOptions
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New CellsBarcodeSignOptions("12345678")
        ' barcode type
        signOptions.EncodeType = BarcodeTypes.Code39Standard
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Cells_Documents_BarCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignCellsDocumentWithBarCodeOptions
    End Sub

    ''' <summary>
    ''' Shows how to sign pdf document with barcode options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignPdfDocumentWithBarCodeOptions(fileName As String)
        'ExStart:SignPdfDocumentWithBarCodeOptions
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New PdfBarcodeSignOptions("12345678")
        ' barcode type
        signOptions.EncodeType = BarcodeTypes.Code39Standard
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_Documents_BarCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignPdfDocumentWithBarCodeOptions
    End Sub


    ''' <summary>
    ''' Shows how to sign sildes document with barcode options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignSlidesDocumentWithBarCodeOptions(fileName As String)
        'ExStart:SignSlidesDocumentWithBarCodeOptions
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New SlidesBarcodeSignOptions("12345678")
        ' barcode type
        signOptions.EncodeType = BarcodeTypes.Code39Extended
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Slides_Documents_BarCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignSlidesDocumentWithBarCodeOptions
    End Sub

    ''' <summary>
    ''' Shows how to sign words document with barcode options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignWordsDocumentWithBarCodeOptions(fileName As String)
        'ExStart:SignWordsDocumentWithBarCodeOptions
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New WordsBarcodeSignOptions("12345678")
        ' barcode type
        signOptions.EncodeType = BarcodeTypes.Code39Extended
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Words_Documents_BarCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignWordsDocumentWithBarCodeOptions
    End Sub

    ''' <summary>
    ''' Shows how to verify Cells documents signed with barcode signature
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    Public Shared Sub VerifyCellsDocumentsSignedWithBarcodeSignature(cellsFileName As String)
        'ExStart:VerifyCellsDocumentsSignedWithBarcodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New CellsVerifyBarcodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' barcode type
        verifyOptions.EncodeType = BarcodeTypes.Code39Standard
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(cellsFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyCellsDocumentsSignedWithBarcodeSignature
    End Sub


    ''' <summary>
    ''' Shows how to verify pdf documents signed with barcode signature
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub VerifyPdfDocumentsSignedWithBarcodeSignature(PdfFileName As String)
        'ExStart:VerifyPdfDocumentsSignedWithBarcodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New PDFVerifyBarcodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' barcode type
        verifyOptions.EncodeType = BarcodeTypes.Code39Standard
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(PdfFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyPdfDocumentsSignedWithBarcodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to verify slides documents signed with barcode signature
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub VerifySlidesDocumentsSignedWithBarcodeSignature(slidesFileName As String)
        'ExStart:VerifySlidesDocumentsSignedWithBarcodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New SlidesVerifyBarcodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' barcode type
        verifyOptions.EncodeType = BarcodeTypes.Code39Standard
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(slidesFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifySlidesDocumentsSignedWithBarcodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to verify words documents signed with barcode signature
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub VerifyWordsDocumentsSignedWithBarcodeSignature(wordsFileName As String)
        'ExStart:VerifyWordsDocumentsSignedWithBarcodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New WordsVerifyBarcodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' barcode type
        verifyOptions.EncodeType = BarcodeTypes.Code39Standard
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(wordsFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyWordsDocumentsSignedWithBarcodeSignature
    End Sub
#End Region

#Region "working with QR-code signatures"

    ''' <summary>
    ''' Shows how to add QR-code in sign options
    ''' Feature is supported in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub AddingQRCode(fileName As String)
        'ExStart:AddingQRCode
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup text signature options
        Dim signOptions = New PdfQRCodeSignOptions()
        'QR-code type
        signOptions.EncodeType = QRCodeTypes.QR
        ' signature text
        signOptions.Text = "12345678901234"
        ' text position
        signOptions.HorizontalAlignment = HorizontalAlignment.Right
        signOptions.VerticalAlignment = VerticalAlignment.Bottom
        'ExEnd:AddingQRCode
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "QRCode_Document"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
    End Sub

    ''' <summary>
    ''' Shows how to sign cells document with QR-code options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignCellsDocumentWithQrCodeSignature(fileName As String)
        'ExStart:SignCellsDocumentWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New CellsQRCodeSignOptions("12345678")
        ' QR-code type
        signOptions.EncodeType = QRCodeTypes.Aztec
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Cells_Documents_QRCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignCellsDocumentWithQrCodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to sign pdf document with QR-code options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignPdfDocumentWithQrCodeSignature(fileName As String)
        'ExStart:SignPdfDocumentWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New PdfQRCodeSignOptions("12345678")
        ' QR-code type
        signOptions.EncodeType = QRCodeTypes.Aztec
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_Documents_QRCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignPdfDocumentWithQrCodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to sign slides document with QR-code options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignSlidesDocumentWithQrCodeSignature(fileName As String)
        'ExStart:SignSlidesDocumentWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New SlidesQRCodeSignOptions("12345678")
        ' QR-code type
        signOptions.EncodeType = QRCodeTypes.Aztec
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Slides_Documents_QRCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignSlidesDocumentWithQrCodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to sign words document with QR-code options
    ''' This feature is availabale in version 17.06 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignWordsDocumentWithQrCodeSignature(fileName As String)
        'ExStart:SignWordsDocumentWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New WordsQRCodeSignOptions("12345678")
        ' QR-code type
        signOptions.EncodeType = QRCodeTypes.Aztec
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(fileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Words_Documents_QRCode"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignWordsDocumentWithQrCodeSignature
    End Sub


    ''' <summary>
    ''' Shows how to verfiry cells documents signed with QR code signature
    ''' Feature is supported in version 17.06 or greater
    ''' </summary>
    ''' <param name="cellsFileName"></param>
    Public Shared Sub VerifyCellsDocumentSignedWithQrCodeSignature(cellsFileName As String)
        'ExStart:VerifyCellsDocumentSignedWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New CellsVerifyQRCodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' QR-code type
        verifyOptions.EncodeType = QRCodeTypes.Aztec
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(cellsFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyCellsDocumentSignedWithQrCodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to verfiry Pdf documents signed with QR code signature
    ''' Feature is supported in version 17.06 or greater
    ''' </summary>
    ''' <param name="pdfFileName"></param>
    Public Shared Sub VerifyPdfDocumentSignedWithQrCodeSignature(pdfFileName As String)
        'ExStart:VerifyPdfDocumentSignedWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New PDFVerifyQRCodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' QR-code type
        verifyOptions.EncodeType = QRCodeTypes.Aztec
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(pdfFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyPdfDocumentSignedWithQrCodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to verfiry Slides documents signed with QR code signature
    ''' Feature is supported in version 17.06 or greater
    ''' </summary>
    ''' <param name="slidesFileName"></param>
    Public Shared Sub VerifySlidesDocumentSignedWithQrCodeSignature(slidesFileName As String)
        'ExStart:VerifySlidesDocumentSignedWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New SlidesVerifyQRCodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' QR-code type
        verifyOptions.EncodeType = QRCodeTypes.Aztec
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(slidesFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifySlidesDocumentSignedWithQrCodeSignature
    End Sub

    ''' <summary>
    ''' Shows how to verfiry Words documents signed with QR code signature
    ''' Feature is supported in version 17.06 or greater
    ''' </summary>
    ''' <param name="wordsFileName"></param>
    Public Shared Sub VerifyWordsDocumentSignedWithQrCodeSignature(wordsFileName As String)
        'ExStart:VerifyWordsDocumentSignedWithQrCodeSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup verification options
        Dim verifyOptions As New WordsVerifyQRCodeOptions()
        ' verify only page with specified number
        verifyOptions.DocumentPageNumber = 1
        ' verify all pages of a document if true
        verifyOptions.VerifyAllPages = True
        ' QR-code type
        verifyOptions.EncodeType = QRCodeTypes.Aztec
        'If verify option Text is set, it will be searched in Title, Subject and Contents
        verifyOptions.Text = "12345678"
        'verify document
        Dim result As VerificationResult = handler.Verify(wordsFileName, verifyOptions)

        Console.WriteLine("Verification result is: " + result.IsValid)
        'ExEnd:VerifyWordsDocumentSignedWithQrCodeSignature
    End Sub
#End Region


#Region "working with Stamp signatures"

    ''' <summary>
    ''' Shows how to add stamp signature to pdf documents
    ''' Feature is supported in version 17.07 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub AddingStampSignature(fileName As String)
        'ExStart:AddingStampSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup text signature options
        Dim signOptions = New PdfStampSignOptions()

        ' OuterLines property contains list of StampLine object that describe Ring with Height, colored, borders
        ' setup first external line of Stamp
        Dim line0 = New StampLine()
        line0.Text = " * European Union * European Union  * European Union  * European Union  * European Union  * "
        line0.Font.FontSize = 12
        line0.Height = 22
        line0.TextBottomIntent = 6
        line0.TextColor = Color.WhiteSmoke
        line0.BackgroundColor = Color.DarkSlateBlue
        signOptions.OuterLines.Add(line0)
        ' draw another stamp ring - specify only thin 2 pixels White part
        Dim line1 = New StampLine()
        line1.Height = 2
        line1.BackgroundColor = Color.White
        signOptions.OuterLines.Add(line1)

        ' add another Stamp ring
        Dim line2 = New StampLine()
        line2.Text = "* Entrepreneur * Entrepreneur ** Entrepreneur * Entrepreneur *"
        line2.TextColor = Color.DarkSlateBlue
        line2.Font.FontSize = 15
        line2.Height = 30
        line2.TextBottomIntent = 8
        line2.InnerBorder.Color = Color.DarkSlateBlue
        line2.OuterBorder.Color = Color.DarkSlateBlue
        line2.InnerBorder.Style = ExtendedDashStyle.Dot
        signOptions.OuterLines.Add(line2)

        'Inner square lines - horizontal lines inside the rings
        Dim line3 = New StampLine()
        line3.Text = "John"
        line3.TextColor = Color.MediumVioletRed
        line3.Font.FontSize = 20
        line3.Font.Bold = True
        line3.Height = 40
        signOptions.InnerLines.Add(line3)

        Dim line4 = New StampLine()
        line4.Text = "Smith"
        line4.TextColor = Color.MediumVioletRed
        line4.Font.FontSize = 20
        line4.Font.Bold = True
        line4.Height = 40
        signOptions.InnerLines.Add(line4)

        Dim line5 = New StampLine()
        line5.Text = "SSN 1230242424"
        line5.TextColor = Color.MediumVioletRed
        line5.Font.FontSize = 12
        line5.Font.Bold = True
        line5.Height = 40
        signOptions.InnerLines.Add(line5)

        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)("test.pdf", signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_Documents_Stamp"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:AddingStampSignature
    End Sub


    ''' <summary>
    ''' Shows how to sign cells document with stamp signature options
    ''' This feature is availabale in version 17.07 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignCellsDocumentWithStampSignature(cellsFileName As String)
        'ExStart:SignCellsDocumentWithStampSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New CellsStampSignOptions()
        signOptions.Height = 120
        signOptions.Width = 300
        'Inner square lines
        Dim line0 As New StampLine()
        line0.Text = "John"
        line0.TextBottomIntent = 0
        line0.TextColor = Color.MediumVioletRed
        line0.OuterBorder.Color = Color.DarkSlateBlue
        line0.InnerBorder.Color = Color.DarkSlateBlue
        line0.InnerBorder.Style = ExtendedDashStyle.Dash
        line0.Font.FontSize = 20
        line0.Font.Bold = True
        line0.Height = 40
        signOptions.InnerLines.Add(line0)
        Dim line1 As New StampLine()
        line1.Text = "Smith"
        line1.TextBottomIntent = 0
        line1.TextColor = Color.MediumVioletRed
        line1.InnerBorder.Color = Color.DarkSlateBlue
        line1.Font.FontSize = 20
        line1.Font.Bold = True
        line1.Height = 40
        signOptions.InnerLines.Add(line1)

        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(cellsFileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Cells_Documents_Stamp"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignCellsDocumentWithStampSignature
    End Sub

    ''' <summary>
    ''' Shows how to sign pdf document with Stamp signature options
    ''' This feature is availabale in version 17.07 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignPdfDocumentWithStampSignature(pdfFileName As String)
        'ExStart:SignPdfDocumentWithStampSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        'All examples for Cells, PDF, Slides and Words Stamp Signatures are different
        ' setup options with text of signature
        Dim signOptions As New PdfStampSignOptions()
        signOptions.Height = 300
        signOptions.Width = 300
        'Outer round lines
        Dim line0 As New StampLine()
        line0.Text = " * European Union * European Union  * European Union  * European Union  * European Union  * "
        line0.Font.FontSize = 12
        line0.Height = 22
        line0.TextBottomIntent = 6
        line0.TextColor = Color.WhiteSmoke
        line0.BackgroundColor = Color.DarkSlateBlue
        signOptions.OuterLines.Add(line0)
        Dim line1 As New StampLine()
        line1.Height = 2
        line1.BackgroundColor = Color.White
        signOptions.OuterLines.Add(line1)
        Dim line2 As New StampLine()
        line2.Text = "* Entrepreneur * Entrepreneur ** Entrepreneur * Entrepreneur *"
        line2.TextColor = Color.DarkSlateBlue
        line2.Font.FontSize = 15
        line2.Height = 30
        line2.TextBottomIntent = 8
        line2.InnerBorder.Color = Color.DarkSlateBlue
        line2.OuterBorder.Color = Color.DarkSlateBlue
        line2.InnerBorder.Style = ExtendedDashStyle.Dot
        signOptions.OuterLines.Add(line2)
        'Inner square lines
        Dim line3 As New StampLine()
        line3.Text = "John"
        line3.TextColor = Color.MediumVioletRed
        line3.Font.FontSize = 20
        line3.Font.Bold = True
        line3.Height = 40
        signOptions.InnerLines.Add(line3)
        Dim line4 As New StampLine()
        line4.Text = "Smith"
        line4.TextColor = Color.MediumVioletRed
        line4.Font.FontSize = 20
        line4.Font.Bold = True
        line4.Height = 40
        signOptions.InnerLines.Add(line4)
        Dim line5 As New StampLine()
        line5.Text = "SSN 1230242424"
        line5.TextColor = Color.MediumVioletRed
        line5.Font.FontSize = 12
        line5.Font.Bold = True
        line5.Height = 40
        signOptions.InnerLines.Add(line5)
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(pdfFileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Pdf_Documents_Stamp"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignPdfDocumentWithStampSignature
    End Sub

    ''' <summary>
    ''' Shows how to sign slides document with stamp signature options
    ''' This feature is availabale in version 17.07 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignSlidesDocumentWithStampSignature(slidesFileName As String)
        'ExStart:SignSlidesDocumentWithStampSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New SlidesStampSignOptions()
        signOptions.Height = 200
        signOptions.Width = 400
        'Outer round lines
        Dim line0 As New StampLine()
        line0.Text = " * John * Smith  * John * Smith  * John * Smith  * John * Smith  * John * Smith * John * Smith *  John * Smith * "
        line0.Font.FontSize = 12
        line0.Height = 22
        line0.TextBottomIntent = 6
        line0.TextColor = Color.WhiteSmoke
        line0.BackgroundColor = Color.DarkSlateBlue
        signOptions.OuterLines.Add(line0)
        'Inner square lines
        Dim line1 As New StampLine()
        line1.Text = "John Smith"
        line1.TextColor = Color.MediumVioletRed
        line1.Font.FontSize = 24
        line1.Font.Bold = True
        line1.Height = 100
        signOptions.InnerLines.Add(line1)
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True
        signOptions.Opacity = 0.8
        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(slidesFileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Slides_Documents_Stamp"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignSlidesDocumentWithStampSignature
    End Sub

    ''' <summary>
    ''' Shows how to sign words document with stamp signature options
    ''' This feature is availabale in version 17.07 or greater
    ''' </summary>
    ''' <param name="fileName"></param>
    Public Shared Sub SignWordsDocumentWithStampSignature(wordsFileName As String)
        'ExStart:SignWordsDocumentWithStampSignature
        ' setup Signature configuration
        Dim signConfig As SignatureConfig = Utilities.GetConfigurations()
        ' instantiating the conversion handler
        Dim handler As New SignatureHandler(signConfig)
        ' setup options with text of signature
        Dim signOptions As New WordsStampSignOptions()
        signOptions.Height = 300
        signOptions.Width = 300
        signOptions.ImageGuid = "stamp.jpg"
        signOptions.BackgroundColor = Color.Aqua

        'Inner square lines
        Dim line0 As New StampLine()
        line0.Text = "John"
        line0.TextColor = Color.MediumVioletRed
        line0.Font.FontSize = 20
        line0.Font.Bold = True
        line0.Height = 40
        signOptions.InnerLines.Add(line0)
        Dim line1 As New StampLine()
        line1.Text = "Smith"
        line1.TextColor = Color.MediumVioletRed
        line1.Font.FontSize = 20
        line1.Font.Bold = True
        line1.Height = 40
        signOptions.InnerLines.Add(line1)
        ' if you need to sign all sheets set it to true
        signOptions.SignAllPages = True

        ' sign document
        Dim signedPath As String = handler.Sign(Of String)(wordsFileName, signOptions, New SaveOptions() With {
            .OutputType = OutputType.[String],
            .OutputFileName = "Words_Documents_Stamp"
        })
        Console.WriteLine(Convert.ToString("Signed file path is: ") & signedPath)
        'ExEnd:SignWordsDocumentWithStampSignature
    End Sub

#End Region




End Class
