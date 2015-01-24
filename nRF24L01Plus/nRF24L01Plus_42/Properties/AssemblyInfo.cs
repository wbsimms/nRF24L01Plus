#region License
// Copyright (C) 2015 by Wm. Barrett Simms (wbsimms)
// http://wbsimms.com
// 
// MIT Licence
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
// Updated version of original code from Jakub Bartkowiak (Gralin)
#endregion

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("GTM.WBSimms.NRF24L01Plus")]
[assembly: AssemblyDescription("Driver for NRF24L01Plus module made by Wm. Barrett Simms for Microsoft .NET Gadgeteer")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Wm. Barrett Simms")]
[assembly: AssemblyProduct("NRF24L01Plus")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// This is the assembly version.  It is often useful to keep this constant between major releases where the API changes
// since a dll relying on this dll will need to be recompiled if this changes.
// Suggestion: use a version number X.Y.0.0 where X and Y indicate major version numbers.
[assembly: AssemblyVersion("1.0.0.0")]

// These numbers must be changed whenever a new version of this dll is released, to allow upgrades to proceed correctly.
// Suggestion: Use a version number X.Y.Z.0 where X.Y.Z is the same as the installer version found in common.wxi
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0.0")]

// Alternatively, if this module is included as part of a kit installer and you want to synchronize version numbers to the kit's,
// follow the instructions in the kit's readme to include the kit's AssemblyInfoGlobal.cs version numbers, and comment out 
// the two version numbers above (AssemblyFileVersion and AssemblyInformationalVersion BUT NOT AssemblyVersion)