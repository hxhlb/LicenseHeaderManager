﻿#region copyright
// Copyright (c) 2011 rubicon IT GmbH

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 
#endregion

// PkgCmdID.cs
// MUST match PkgCmdID.h

namespace LicenseHeaderManager
{
    static class PkgCmdIDList
    {
      public const uint cmdIdLicenseHeaderOptions = 0x0001;
      public const uint cmdIdAddLicenseHeader = 0x0002;
      public const uint cmdIdRemoveLicenseHeader = 0x0003;
      public const uint cmdIdAddLicenseHeadersToAllFiles = 0x004;
      public const uint cmdIdRemoveLicenseHeadersFromAllFiles = 0x0005;
      public const uint cmdIdAddLicenseHeaderDefinitionFile = 0x0006;
      public const uint cmdIdAddExistingLicenseHeaderDefinitionFile = 0x0007;
      public const uint cmdIdAddLicenseHeaderToProjectItem = 0x0008;
      public const uint cmdIdRemoveLicenseHeaderFromProjectItem = 0x0009;
      public const uint cmdIdAddLicenseHeaderToAllProjects = 0x0010;
      public const uint cmdIdRemoveLicenseHeaderFromAllProjects = 0x0011;
    };
}