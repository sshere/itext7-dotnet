/*
This file is part of the iText (R) project.
Copyright (c) 1998-2018 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using iText.IO.Util;
using iText.StyledXmlParser.Exceptions;
using iText.Svg.Renderers;
using iText.Test;

namespace iText.Svg.Renderers.Impl {
    public class SimpleSvgTagSvgNodeRendererIntegrationTest : SvgIntegrationTest {
        private static readonly String SOURCE_FOLDER = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/svg/renderers/impl/RootSvgNodeRendererTest/svg/";

        private static readonly String DESTINATION_FOLDER = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/svg/renderers/impl/RootSvgNodeRendererTest/svg/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            ITextTest.CreateDestinationFolder(DESTINATION_FOLDER);
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void EverythingPresentAndValidTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "everythingPresentAndValid");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void AbsentEverything() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "absentEverything");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>().With.Message.EqualTo(MessageFormatUtil.Format(iText.StyledXmlParser.LogMessageConstant.NAN, "null")));
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void AbsentHeight() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "absentHeight");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>().With.Message.EqualTo(MessageFormatUtil.Format(iText.StyledXmlParser.LogMessageConstant.NAN, "null")));
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void AbsentWidth() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "absentWidth");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>().With.Message.EqualTo(MessageFormatUtil.Format(iText.StyledXmlParser.LogMessageConstant.NAN, "null")));
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void AbsentWidthAndHeight() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "absentWidthAndHeight");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>().With.Message.EqualTo(MessageFormatUtil.Format(iText.StyledXmlParser.LogMessageConstant.NAN, "null")));
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void AbsentX() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "absentX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void AbsentY() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "absentY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void InvalidHeight() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "invalidHeight");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>().With.Message.EqualTo(MessageFormatUtil.Format(iText.StyledXmlParser.LogMessageConstant.NAN, "abc")));
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void InvalidWidth() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "invalidWidth");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>().With.Message.EqualTo(MessageFormatUtil.Format(iText.StyledXmlParser.LogMessageConstant.NAN, "abc")));
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void InvalidX() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "invalidX");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>());
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void InvalidY() {
            NUnit.Framework.Assert.That(() =>  {
                ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "invalidY");
            }
            , NUnit.Framework.Throws.TypeOf<StyledXMLParserException>());
;
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void NegativeEverything() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "negativeEverything");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void NegativeHeight() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "negativeHeight");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void NegativeWidth() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "negativeWidth");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void NegativeWidthAndHeight() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "negativeWidthAndHeight");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void NegativeX() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "negativeX");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void NegativeXY() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "negativeXY");
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void NegativeY() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "negativeY");
        }
    }
}
