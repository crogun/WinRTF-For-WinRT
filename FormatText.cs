/**
 * Author : BEN OUIREN Farid
 * Date :2013-03-16
 * email : crogun@gmail.com
 * Licence : Creative Commons 
 * The licensor permits others to copy, distribute, display, and perform the work. In return, licenses must give the original author credit.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestORMSQlite.WinRTF
{
    /// <summary>
    /// This class help you to format text in different format.
    /// Your turn to enrich.
    /// </summary>
    public class FormatText
    {

        /// <summary>
        /// this method format title for you.
        /// </summary>
        /// <param name="title">the sample title that you want make</param>
        /// <returns>the title formated</returns>
        public string formatTitle(string title)
        {
            return @"{\f1\fs32 \par \qc \b " + title + "}";
        }

        /// <summary>
        /// this method format content for you.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string formatContent(string content)
        {
            return  @"{\f1\fs20 \par \qj  " + content + "}";
        }

        /// <summary>
        /// this method format Header for you.
        /// </summary>
        /// <param name="hr"></param>
        /// <returns></returns>
        public string formatTableHeader(string hr)
        {
            return @"{\f1\fs36  \qj  " + hr + "}";

        }

        /// <summary>
        /// this method format a table for you.
        /// </summary>
        /// <param name="tr"></param>
        /// <returns></returns>
        public string formatTableRow(string tr)
        {
            return @"{\f2\fs26  \ql  " + tr + "}";

        }

        /// <summary>
        /// this method format line of a list for you.
        /// </summary>
        /// <param name="li"></param>
        /// <returns></returns>
        public string formatLineList(string li)
        {
            return @"\par {\listtext\pard\plain\ltrpar \rtlch\fcs1 \af0\afs28 \ltrch\fcs0 \f3\fs28\insrsid7163344\charrsid818954 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}}{\rtlch\fcs1 \af0\afs28 \ltrch\fcs0 \f0\fs28\insrsid7163344\charrsid818954 \hich\af0\dbch\af31505\loch\f0 " + li;
        }

        /// <summary>
        /// this method format sample line for you.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string formatLine(string line)
        {
            return @"\f1\fs16  \qj  " + line + @"\line";
        }

        /// <summary>
        /// this method format the header for you.
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>
        public string formatHeader(string header)
        {
            return @"\f1\fs16  \ql  " + header + @"\line";
        }

        /// <summary>
        /// this method format the footer for you.
        /// </summary>
        /// <param name="footer"></param>
        /// <returns></returns>
        public string formatFooter(string footer)
        {
            return @"\f1\fs16  \qr  " + footer + @"\line";
        }

    }
}
