// Copyright � 2006-2010 Travis Robinson. All rights reserved.
//
// website: http://sourceforge.net/projects/libusbdotnet
// e-mail:  libusbdotnet@gmail.com
//
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
//
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or
// visit www.gnu.org.
//
//
using System;

namespace LibUsbDotNet.Main
{
    /// <summary>
    ///  Represents an exception generated by a USB operation.
    /// </summary>
    public class UsbException : Exception
    {
        private readonly object mSender;

        /// <summary>
        /// LibUsbDotNet USB exception.
        /// </summary>
        public UsbException(object sender, string description)
            : base(description)
        {
            mSender = sender;
        }

        /// <summary>
        /// The object that caused the exception.
        /// </summary>
        public object Sender
        {
            get { return mSender; }
        }
    }
}