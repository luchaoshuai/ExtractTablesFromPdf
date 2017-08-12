﻿using System;
using System.Collections.Generic;
using iTextSharp.text.pdf;

namespace BuildTablesFromPdf.Engine.Statements
{
    public abstract class MultiLineStatement : Statement
    {
        public PdfReader PdfReader { get; private set; }
        public int PageNumber { get; private set; }

        public MultiLineStatement(PdfReader pdfReader, int pageNumber)
        {
            PdfReader = pdfReader;
            PageNumber = pageNumber;
            RawContent = new List<string>();
        }

        /// <summary>
        /// Closes the multi line statement.
        /// </summary>
        public abstract void CloseMultiLineStatement();

        public List<string> RawContent { get; private set; }
    }
}
