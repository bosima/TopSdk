#region MIT License
/**
 * Ext.cs
 *  IsPredefinedScheme and MaybeUri methods derived from System.Uri.cs
 *  GetStatusDescription method derived from System.Net.HttpListenerResponse.cs
 *
 * The MIT License
 *
 * Copyright (c) 2010-2012 sta.blockhead
 *
 * System.Uri.cs
 * (C) 2001 Garrett Rooney
 * (C) 2003 Ian MacLean
 * (C) 2003 Ben Maurer
 * Copyright (C) 2003, 2005, 2009 Novell, Inc. (http://www.novell.com)
 * Copyright (c) 2009 Stephane Delcroix
 *
 * System.Net.HttpListenerResponse.cs
 * Copyright (C) 2003, 2005, 2009 Novell, Inc. (http://www.novell.com)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net.Sockets;
using System.Text;
using WebSocketSharp.Net;
using WebSocketSharp.Net.Sockets;

namespace WebSocketSharp
{
    public delegate void Action();
    public delegate void Action<T1, T2>(T1 t1, T2 t2);
    public delegate void Action<T1, T2, T3>(T1 t1, T2 t2, T3 t3);
    public delegate void Action<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4);
    public delegate TResult Func<T1, TResult>(T1 t1);
    /// <summary>Provides a set of static methods for the websocket-sharp.
    /// </summary>
    public static class Ext
    {
        #region Private Methods

        private static void times(ulong n, Action act)
        {
            for (ulong i = 0; i < n; i++)
                act();
        }

        private static void times(ulong n, Action<ulong> act)
        {
            for (ulong i = 0; i < n; i++)
                act(i);
        }

        private static byte[] Reverse(byte[] array)
        {
            Array.Reverse(array);
            return array;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Accept a WebSocket connection by the <see cref="TcpListener"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="WebSocketSharp.Net.Sockets.TcpListenerWebSocketContext"/> that contains a WebSocket connection.
        /// </returns>
        /// <param name="client">
        /// A <see cref="TcpClient"/> that contains a TCP connection to accept a WebSocket connection from.
        /// </param>
        /// <param name="secure">
        /// A <see cref="bool"/> that indicates a secure connection or not. (<c>true</c> indicates a secure connection.)
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Is thrown when the <paramref name="client"/> parameter passed to a method is invalid because it is <see langword="null"/>.
        /// </exception>
        public static TcpListenerWebSocketContext AcceptWebSocket(TcpClient client, bool secure)
        {
            if (client == null)
                throw new ArgumentNullException("client");

            return new TcpListenerWebSocketContext(client, secure);
        }

        /// <summary>
        /// Emit the specified <see cref="EventHandler"/> delegate if is not <see langword="null"/>.
        /// </summary>
        /// <param name="eventHandler">
        /// An <see cref="EventHandler"/> to emit.
        /// </param>
        /// <param name="sender">
        /// An <see cref="object"/> that emits the <paramref name="eventHandler"/>.
        /// </param>
        /// <param name="e">
        /// An <see cref="EventArgs"/> that contains no event data.
        /// </param>
        public static void Emit(
           EventHandler eventHandler, object sender, EventArgs e)
        {
            if (eventHandler != null)
                eventHandler(sender, e);
        }

        /// <summary>
        /// Emit the specified <see cref="EventHandler&lt;TEventArgs&gt;"/> delegate if is not <see langword="null"/>.
        /// </summary>
        /// <param name="eventHandler">
        /// An <see cref="EventHandler&lt;TEventArgs&gt;"/> to emit.
        /// </param>
        /// <param name="sender">
        /// An <see cref="object"/> that emits the <paramref name="eventHandler"/>.
        /// </param>
        /// <param name="e">
        /// An <see cref="EventArgs"/> that contains the event data.
        /// </param>
        /// <typeparam name="TEventArgs">
        /// The type of the event data generated by the event.
        /// </typeparam>
        public static void Emit<TEventArgs>(
           EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
          where TEventArgs : EventArgs
        {
            if (eventHandler != null)
                eventHandler(sender, e);
        }

        /// <summary>
        /// Determines whether the specified <see cref="int"/> equals the specified <see cref="char"/> as <see cref="byte"/>.
        /// And save this specified <see cref="int"/> as <see cref="byte"/> to the specified <see cref="List&lt;byte&gt;"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="value"/> parameter equals the <paramref name="c"/> parameter as <see cref="byte"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="value">
        /// An <see cref="int"/> to compare.
        /// </param>
        /// <param name="c">
        /// A <see cref="char"/> to compare.
        /// </param>
        /// <param name="dest">
        /// A <see cref="List&lt;byte&gt;"/> to save the <paramref name="value"/> as <see cref="byte"/>.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Is thrown when the <paramref name="value"/> parameter passed to a method is invalid because it is outside the allowable range of values as <see cref="byte"/>.
        /// </exception>
        public static bool EqualsAndSaveTo(int value, char c, List<byte> dest)
        {
            if (value < 0 || value > 255)
                throw new ArgumentOutOfRangeException("value");

            var b = (byte)value;
            dest.Add(b);

            return b == Convert.ToByte(c);
        }

        /// <summary>
        /// Determines whether the entry with the specified key exists in the specified <see cref="NameValueCollection"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the entry with the <paramref name="name"/> exists in the <paramref name="collection"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="collection">
        /// A <see cref="NameValueCollection"/> that contains the entries.
        /// </param>
        /// <param name="name">
        /// A <see cref="string"/> that contains the key of the entry to find.
        /// </param>
        public static bool Exists(NameValueCollection collection, string name)
        {
            return collection == null
                   ? false
                   : collection[name] != null;
        }

        /// <summary>
        /// Determines whether the entry with the specified both key and value exists in the specified <see cref="NameValueCollection"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the entry with the both <paramref name="name"/> and <paramref name="value"/> exists in the <paramref name="collection"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="collection">
        /// A <see cref="NameValueCollection"/> that contains the entries.
        /// </param>
        /// <param name="name">
        /// A <see cref="string"/> that contains the key of the entry to find.
        /// </param>
        /// <param name="value">
        /// A <see cref="string"/> that contains the value of the entry to find.
        /// </param>
        public static bool Exists(NameValueCollection collection, string name, string value)
        {
            if (collection == null)
                return false;

            var values = collection[name];
            if (values == null)
                return false;

            foreach (string v in values.Split(','))
                if (String.Compare(v.Trim(), value, true) == 0)
                    return true;

            return false;
        }

        /// <summary>
        /// Gets the absolute path from the specified <see cref="Uri"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the absolute path if got successfully; otherwise, <see langword="null"/>.
        /// </returns>
        /// <param name="uri">
        /// A <see cref="Uri"/> that contains the URI to get the absolute path from.
        /// </param>
        public static string GetAbsolutePath(Uri uri)
        {
            if (uri == null)
                return null;

            if (uri.IsAbsoluteUri)
                return uri.AbsolutePath;

            var uriString = uri.OriginalString;
            var i = uriString.IndexOf('/');
            if (i != 0)
                return null;

            i = uriString.IndexOfAny(new[] { '?', '#' });
            return i > 0
                   ? uriString.Substring(0, i)
                   : uriString;
        }

        /// <summary>
        /// Gets the description of the HTTP status code using the specified code.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the description of the <paramref name="code"/>.
        /// </returns>
        /// <param name="code">
        /// One of <see cref="WebSocketSharp.Net.HttpStatusCode"/> values that contains the HTTP status code.
        /// </param>
        public static string GetDescription(HttpStatusCode code)
        {
            return GetStatusDescription((int)code);
        }

        /// <summary>
        /// Gets the name from the specified <see cref="string"/> that contains a pair of name and value are separated by a separator string.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the name if any; otherwise, <c>null</c>.
        /// </returns>
        /// <param name="nameAndValue">
        /// A <see cref="string"/> that contains a pair of name and value are separated by a separator string.
        /// </param>
        /// <param name="separator">
        /// A <see cref="string"/> that contains a separator string.
        /// </param>
        public static string GetName(string nameAndValue, string separator)
        {
            if (IsNullOrEmpty(nameAndValue))
                return null;

            if (IsNullOrEmpty(separator))
                return null;

            var i = nameAndValue.IndexOf(separator);
            return i > 0
                   ? nameAndValue.Substring(0, i).Trim()
                   : null;
        }

        /// <summary>
        /// Gets the name and value from the specified <see cref="string"/> that contains a pair of name and value are separated by a separator string.
        /// </summary>
        /// <returns>
        /// A <see cref="KeyValuePair&lt;string, string&gt;"/> that contains the name and value if any.
        /// </returns>
        /// <param name="nameAndValue">
        /// A <see cref="string"/> that contains a pair of name and value are separated by a separator string.
        /// </param>
        /// <param name="separator">
        /// A <see cref="string"/> that contains a separator string.
        /// </param>
        public static KeyValuePair<string, string> GetNameAndValue(string nameAndValue, string separator)
        {
            var name = GetName(nameAndValue, separator);
            var value = GetValue(nameAndValue, separator);
            return name != null
                   ? new KeyValuePair<string, string>(name, value)
                   : new KeyValuePair<string, string>(null, null);
        }

        /// <summary>
        /// Gets the description of the HTTP status code using the specified code.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the description of the <paramref name="code"/>.
        /// </returns>
        /// <param name="code">
        /// An <see cref="int"/> that contains the HTTP status code.
        /// </param>
        public static string GetStatusDescription(int code)
        {
            switch (code)
            {
                case 100: return "Continue";
                case 101: return "Switching Protocols";
                case 102: return "Processing";
                case 200: return "OK";
                case 201: return "Created";
                case 202: return "Accepted";
                case 203: return "Non-Authoritative Information";
                case 204: return "No Content";
                case 205: return "Reset Content";
                case 206: return "Partial Content";
                case 207: return "Multi-Status";
                case 300: return "Multiple Choices";
                case 301: return "Moved Permanently";
                case 302: return "Found";
                case 303: return "See Other";
                case 304: return "Not Modified";
                case 305: return "Use Proxy";
                case 307: return "Temporary Redirect";
                case 400: return "Bad Request";
                case 401: return "Unauthorized";
                case 402: return "Payment Required";
                case 403: return "Forbidden";
                case 404: return "Not Found";
                case 405: return "Method Not Allowed";
                case 406: return "Not Acceptable";
                case 407: return "Proxy Authentication Required";
                case 408: return "Request Timeout";
                case 409: return "Conflict";
                case 410: return "Gone";
                case 411: return "Length Required";
                case 412: return "Precondition Failed";
                case 413: return "Request Entity Too Large";
                case 414: return "Request-Uri Too Long";
                case 415: return "Unsupported Media Type";
                case 416: return "Requested Range Not Satisfiable";
                case 417: return "Expectation Failed";
                case 422: return "Unprocessable Entity";
                case 423: return "Locked";
                case 424: return "Failed Dependency";
                case 500: return "Internal Server Error";
                case 501: return "Not Implemented";
                case 502: return "Bad Gateway";
                case 503: return "Service Unavailable";
                case 504: return "Gateway Timeout";
                case 505: return "Http Version Not Supported";
                case 507: return "Insufficient Storage";
            }

            return String.Empty;
        }

        /// <summary>
        /// Gets the value from the specified <see cref="string"/> that contains a pair of name and value are separated by a separator string.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the value if any; otherwise, <c>null</c>.
        /// </returns>
        /// <param name="nameAndValue">
        /// A <see cref="string"/> that contains a pair of name and value are separated by a separator string.
        /// </param>
        /// <param name="separator">
        /// A <see cref="string"/> that contains a separator string.
        /// </param>
        public static string GetValue(string nameAndValue, string separator)
        {
            if (IsNullOrEmpty(nameAndValue))
                return null;

            if (IsNullOrEmpty(separator))
                return null;

            var i = nameAndValue.IndexOf(separator);
            return i >= 0 && i < nameAndValue.Length - 1
                   ? nameAndValue.Substring(i + 1).Trim()
                   : null;
        }

        /// <summary>
        /// Determines whether the specified <see cref="string"/> is a <see cref="String.Empty"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="value"/> parameter is a <see cref="String.Empty"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="value">
        /// A <see cref="string"/> to test.
        /// </param>
        public static bool IsEmpty(string value)
        {
            return value == String.Empty ? true : false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="WebSocketSharp.ByteOrder"/> is host (this computer architecture) byte order.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="order"/> parameter is host byte order; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="order">
        /// A <see cref="WebSocketSharp.ByteOrder"/> to test.
        /// </param>
        public static bool IsHostOrder(ByteOrder order)
        {
            // true : !(true ^ true)  or !(false ^ false)
            // false: !(true ^ false) or !(false ^ true)
            return !(BitConverter.IsLittleEndian ^ (order == ByteOrder.LITTLE));
        }

        /// <summary>
        /// Determines whether the specified object is <see langword="null"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="obj"/> parameter is <see langword="null"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="obj">
        /// A <see cref="class"/> to test.
        /// </param>
        /// <typeparam name="T">
        /// The type of the <paramref name="obj"/> parameter.
        /// </typeparam>
        public static bool IsNull<T>(T obj)
          where T : class
        {
            return obj == null ? true : false;
        }

        /// <summary>
        /// Determines whether the specified object is <see langword="null"/>.
        /// And invokes the specified <see cref="Action"/> delegate if the specified object is <see langword="null"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="obj"/> parameter is <see langword="null"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="obj">
        /// A <see cref="class"/> to test.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action"/> delegate that contains the method(s) called if the <paramref name="obj"/> is <see langword="null"/>.
        /// </param>
        /// <typeparam name="T">
        /// The type of the <paramref name="obj"/> parameter.
        /// </typeparam>
        public static bool IsNullDo<T>(T obj, Action act)
          where T : class
        {
            if (obj == null)
            {
                act();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="string"/> is <see langword="null"/> or <see cref="String.Empty"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="value"/> parameter is <see langword="null"/> or <see cref="String.Empty"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="value">
        /// A <see cref="string"/> to test.
        /// </param>
        public static bool IsNullOrEmpty(string value)
        {
            return String.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Determines whether the specified <see cref="string"/> is predefined scheme.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="scheme"/> parameter is the predefined scheme; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="scheme">
        /// A <see cref="string"/> to test.
        /// </param>
        public static bool IsPredefinedScheme(string scheme)
        {
            if (scheme == null && scheme.Length < 2)
                return false;

            char c = scheme[0];
            if (c == 'h')
                return (scheme == "http" || scheme == "https");

            if (c == 'f')
                return (scheme == "file" || scheme == "ftp");

            if (c == 'w')
                return (scheme == "ws" || scheme == "wss");

            if (c == 'n')
            {
                c = scheme[1];
                if (c == 'e')
                    return (scheme == "news" || scheme == "net.pipe" || scheme == "net.tcp");

                if (scheme == "nntp")
                    return true;

                return false;
            }

            if ((c == 'g' && scheme == "gopher") || (c == 'm' && scheme == "mailto"))
                return true;

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="string"/> is valid absolute path.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="absPath"/> parameter is valid absolute path; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="absPath">
        /// A <see cref="string"/> to test.
        /// </param>
        /// <param name="message">
        /// A <see cref="string"/> that receives a message if the <paramref name="absPath"/> is invalid.
        /// </param>
        public static bool IsValidAbsolutePath(string absPath, out string message)
        {
            if (IsNullOrEmpty(absPath))
            {
                message = "Must not be null or empty.";
                return false;
            }

            var i = absPath.IndexOf('/');
            if (i != 0)
            {
                message = "Not absolute path: " + absPath;
                return false;
            }

            i = absPath.IndexOfAny(new[] { '?', '#' });
            if (i != -1)
            {
                message = "Must not contain either or both query and fragment components: " + absPath;
                return false;
            }

            message = String.Empty;
            return true;
        }

        /// <summary>
        /// Determines whether the specified <see cref="string"/> is a URI string.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the <paramref name="uriString"/> parameter is maybe a URI string; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="uriString">
        /// A <see cref="string"/> to test.
        /// </param>
        public static bool MaybeUri(string uriString)
        {
            if (IsNullOrEmpty(uriString))
                return false;

            int p = uriString.IndexOf(':');
            if (p == -1)
                return false;

            if (p >= 10)
                return false;

            return IsPredefinedScheme(uriString.Substring(0, p));
        }

        /// <summary>
        /// Determines whether two specified <see cref="string"/> objects don't have the same value.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the value of <paramref name="expected"/> parameter isn't the same as the value of <paramref name="actual"/> parameter; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="expected">
        /// The first <see cref="string"/> to compare.
        /// </param>
        /// <param name="actual">
        /// The second <see cref="string"/> to compare.
        /// </param>
        /// <param name="ignoreCase">
        /// A <see cref="bool"/> that indicates a case-sensitive or insensitive comparison. (<c>true</c> indicates a case-insensitive comparison.)
        /// </param>
        public static bool NotEqual(string expected, string actual, bool ignoreCase)
        {
            return String.Compare(expected, actual, ignoreCase) != 0
                   ? true
                   : false;
        }

        /// <summary>
        /// Reads a block of bytes from the specified stream and returns the read data in an array of <see cref="byte"/>.
        /// </summary>
        /// <returns>
        /// An array of <see cref="byte"/> that receives the read data.
        /// </returns>
        /// <param name="stream">
        /// A <see cref="Stream"/> that contains the data to read.
        /// </param>
        /// <param name="length">
        /// An <see cref="int"/> that contains the number of bytes to read.
        /// </param>
        public static byte[] ReadBytes(Stream stream, int length)
        {
            if (stream == null || length <= 0)
                return new byte[] { };

            var buffer = new byte[length];
            var readLen = stream.Read(buffer, 0, length);
            var temp = 0;
            while (readLen < length)
            {
                temp = stream.Read(buffer, readLen, length - readLen);
                if (temp < 1)
                    break;
                readLen += temp;
            }

            return readLen == length
                   ? buffer
                   : readLen > 0
                     ? SubArray(buffer, 0, readLen)
                     : new byte[] { };
        }

        /// <summary>
        /// Reads a block of bytes from the specified stream and returns the read data in an array of <see cref="byte"/>.
        /// </summary>
        /// <returns>
        /// An array of <see cref="byte"/> that receives the read data.
        /// </returns>
        /// <param name="stream">
        /// A <see cref="Stream"/> that contains the data to read.
        /// </param>
        /// <param name="length">
        /// A <see cref="long"/> that contains the number of bytes to read.
        /// </param>
        public static byte[] ReadBytes(Stream stream, long length)
        {
            return ReadBytes(stream, length, 1024);
        }

        /// <summary>
        /// Reads a block of bytes from the specified stream and returns the read data in an array of <see cref="byte"/>.
        /// </summary>
        /// <returns>
        /// An array of <see cref="byte"/> that receives the read data.
        /// </returns>
        /// <param name="stream">
        /// A <see cref="Stream"/> that contains the data to read.
        /// </param>
        /// <param name="length">
        /// A <see cref="long"/> that contains the number of bytes to read.
        /// </param>
        /// <param name="bufferLength">
        /// An <see cref="int"/> that contains the buffer size in bytes of each internal read.
        /// </param>
        public static byte[] ReadBytes(Stream stream, long length, int bufferLength)
        {
            if (stream == null || length <= 0)
                return new byte[] { };

            if (bufferLength <= 0)
                bufferLength = 1024;

            var count = length / bufferLength;
            var rem = length % bufferLength;
            var readData = new List<byte>();
            var readBuffer = new byte[bufferLength];
            long readLen = 0;
            var tmpLen = 0;

            Action<byte[]> read = (buffer) =>
            {
                tmpLen = stream.Read(buffer, 0, buffer.Length);
                if (tmpLen > 0)
                {
                    readLen += tmpLen;
                    readData.AddRange(SubArray(buffer, 0, tmpLen));
                }
            };

            Times(count, () =>
            {
                read(readBuffer);
            });

            if (rem > 0)
                read(new byte[rem]);

            return readLen > 0
                   ? readData.ToArray()
                   : new byte[] { };
        }

        /// <summary>
        /// Retrieves a sub-array from the specified <paramref name="array"/>. A sub-array starts at the specified element position.
        /// </summary>
        /// <returns>
        /// An array of T that receives a sub-array, or an empty array of T if any problems with the parameters.
        /// </returns>
        /// <param name="array">
        /// An array of T that contains the data to retrieve a sub-array.
        /// </param>
        /// <param name="startIndex">
        /// An <see cref="int"/> that contains the zero-based starting position of a sub-array in the <paramref name="array"/>.
        /// </param>
        /// <param name="length">
        /// An <see cref="int"/> that contains the number of elements to retrieve a sub-array.
        /// </param>
        /// <typeparam name="T">
        /// The type of elements in the <paramref name="array"/>.
        /// </typeparam>
        public static T[] SubArray<T>(T[] array, int startIndex, int length)
        {
            if (array == null || array.Length == 0)
                return new T[] { };

            if (startIndex < 0 || length <= 0)
                return new T[] { };

            if (startIndex + length > array.Length)
                return new T[] { };

            if (startIndex == 0 && array.Length == length)
                return array;

            T[] subArray = new T[length];
            Array.Copy(array, startIndex, subArray, 0, length);

            return subArray;
        }

        /// <summary>
        /// Executes the specified <see cref="Action"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// An <see cref="int"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action"/> delegate that contains the method(s) to execute.
        /// </param>
        public static void Times(int n, Action act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Executes the specified <see cref="Action"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// A <see cref="long"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action"/> delegate that contains the method(s) to execute.
        /// </param>
        public static void Times(long n, Action act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Executes the specified <see cref="Action"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// A <see cref="uint"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action"/> delegate that contains the method(s) to execute.
        /// </param>
        public static void Times(uint n, Action act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Executes the specified <see cref="Action"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// A <see cref="ulong"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action"/> delegate that contains the method(s) to execute.
        /// </param>
        public static void Times(ulong n, Action act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Executes the specified <see cref="Action&lt;ulong&gt;"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// An <see cref="int"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action&lt;ulong&gt;"/> delegate that contains the method(s) to execute.
        /// A <see cref="ulong"/> parameter to pass to this method(s) contains the zero-based count of iteration.
        /// </param>
        public static void Times(int n, Action<ulong> act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Executes the specified <see cref="Action&lt;ulong&gt;"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// A <see cref="long"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action&lt;ulong&gt;"/> delegate that contains the method(s) to execute.
        /// A <see cref="ulong"/> parameter to pass to this method(s) contains the zero-based count of iteration.
        /// </param>
        public static void Times(long n, Action<ulong> act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Executes the specified <see cref="Action&lt;ulong&gt;"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// A <see cref="uint"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action&lt;ulong&gt;"/> delegate that contains the method(s) to execute.
        /// A <see cref="ulong"/> parameter to pass to this method(s) contains the zero-based count of iteration.
        /// </param>
        public static void Times(uint n, Action<ulong> act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Executes the specified <see cref="Action&lt;ulong&gt;"/> delegate <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">
        /// A <see cref="ulong"/> that contains the number of times to execute.
        /// </param>
        /// <param name="act">
        /// An <see cref="Action&lt;ulong&gt;"/> delegate that contains the method(s) to execute.
        /// A <see cref="ulong"/> parameter to pass to this method(s) contains the zero-based count of iteration.
        /// </param>
        public static void Times(ulong n, Action<ulong> act)
        {
            if (n > 0 && act != null)
                times((ulong)n, act);
        }

        /// <summary>
        /// Converts the specified array of <see cref="byte"/> to the specified type data.
        /// </summary>
        /// <returns>
        /// A T converted from the <paramref name="src"/>, or a default value of T
        /// if the <paramref name="src"/> is an empty array of <see cref="byte"/>
        /// or if the types of T aren't the <see cref="bool"/>, <see cref="char"/>, <see cref="double"/>,
        /// <see cref="float"/>, <see cref="int"/>, <see cref="long"/>, <see cref="short"/>,
        /// <see cref="uint"/>, <see cref="ulong"/>, <see cref="ushort"/>.
        /// </returns>
        /// <param name="src">
        /// An array of <see cref="byte"/> to convert.
        /// </param>
        /// <param name="srcOrder">
        /// A <see cref="WebSocketSharp.ByteOrder"/> that indicates the byte order of the <paramref name="src"/>.
        /// </param>
        /// <typeparam name="T">
        /// The type of the return value. The T must be a value type.
        /// </typeparam>
        /// <exception cref="ArgumentNullException">
        /// Is thrown when the <paramref name="src"/> parameter passed to a method is invalid because it is <see langword="null"/>.
        /// </exception>
        public static T To<T>(byte[] src, ByteOrder srcOrder)
          where T : struct
        {
            if (src == null)
                throw new ArgumentNullException("src");

            if (src.Length == 0)
                return default(T);

            var type = typeof(T);
            var buffer = ToHostOrder(src, srcOrder);
            if (type == typeof(Boolean))
                return (T)(object)BitConverter.ToBoolean(buffer, 0);

            if (type == typeof(Char))
                return (T)(object)BitConverter.ToChar(buffer, 0);

            if (type == typeof(Double))
                return (T)(object)BitConverter.ToDouble(buffer, 0);

            if (type == typeof(Int16))
                return (T)(object)BitConverter.ToInt16(buffer, 0);

            if (type == typeof(Int32))
                return (T)(object)BitConverter.ToInt32(buffer, 0);

            if (type == typeof(Int64))
                return (T)(object)BitConverter.ToInt64(buffer, 0);

            if (type == typeof(Single))
                return (T)(object)BitConverter.ToSingle(buffer, 0);

            if (type == typeof(UInt16))
                return (T)(object)BitConverter.ToUInt16(buffer, 0);

            if (type == typeof(UInt32))
                return (T)(object)BitConverter.ToUInt32(buffer, 0);

            if (type == typeof(UInt64))
                return (T)(object)BitConverter.ToUInt64(buffer, 0);

            return default(T);
        }

        /// <summary>
        /// Converts the specified data to an array of <see cref="byte"/>.
        /// </summary>
        /// <returns>
        /// An array of <see cref="byte"/> converted from the <paramref name="value"/>.
        /// </returns>
        /// <param name="value">
        /// A T to convert.
        /// </param>
        /// <param name="order">
        /// A <see cref="WebSocketSharp.ByteOrder"/> that indicates the byte order of the return.
        /// </param>
        /// <typeparam name="T">
        /// The type of the <paramref name="value"/>. The T must be a value type.
        /// </typeparam>
        public static byte[] ToBytes<T>(T value, ByteOrder order)
          where T : struct
        {
            var type = typeof(T);
            byte[] buffer;
            if (type == typeof(Boolean))
            {
                buffer = BitConverter.GetBytes((Boolean)(object)value);
            }
            else if (type == typeof(Char))
            {
                buffer = BitConverter.GetBytes((Char)(object)value);
            }
            else if (type == typeof(Double))
            {
                buffer = BitConverter.GetBytes((Double)(object)value);
            }
            else if (type == typeof(Int16))
            {
                buffer = BitConverter.GetBytes((Int16)(object)value);
            }
            else if (type == typeof(Int32))
            {
                buffer = BitConverter.GetBytes((Int32)(object)value);
            }
            else if (type == typeof(Int64))
            {
                buffer = BitConverter.GetBytes((Int64)(object)value);
            }
            else if (type == typeof(Single))
            {
                buffer = BitConverter.GetBytes((Single)(object)value);
            }
            else if (type == typeof(UInt16))
            {
                buffer = BitConverter.GetBytes((UInt16)(object)value);
            }
            else if (type == typeof(UInt32))
            {
                buffer = BitConverter.GetBytes((UInt32)(object)value);
            }
            else if (type == typeof(UInt64))
            {
                buffer = BitConverter.GetBytes((UInt64)(object)value);
            }
            else
            {
                buffer = new byte[] { };
            }

            return buffer.Length == 0 || IsHostOrder(order)
                   ? buffer
                   : Reverse(buffer);
        }

        /// <summary>
        /// Converts the order of the specified array of <see cref="byte"/> to the host byte order.
        /// </summary>
        /// <returns>
        /// An array of <see cref="byte"/> converted from the <paramref name="src"/>.
        /// </returns>
        /// <param name="src">
        /// An array of <see cref="byte"/> to convert.
        /// </param>
        /// <param name="srcOrder">
        /// A <see cref="WebSocketSharp.ByteOrder"/> that indicates the byte order of the <paramref name="src"/>.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Is thrown when the <paramref name="src"/> parameter passed to a method is invalid because it is <see langword="null"/>.
        /// </exception>
        public static byte[] ToHostOrder(byte[] src, ByteOrder srcOrder)
        {
            if (src == null)
                throw new ArgumentNullException("src");

            return src.Length == 0 || IsHostOrder(srcOrder)
                   ? src
                   : Reverse(src);
        }

        /// <summary>
        /// Converts the specified array to a <see cref="string"/> concatenated the specified separator string
        /// between each element of this array.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> converted from the <paramref name="array"/> parameter, or a <see cref="String.Empty"/>
        /// if the length of the <paramref name="array"/> is zero.
        /// </returns>
        /// <param name="array">
        /// An array of T to convert.
        /// </param>
        /// <param name="separator">
        /// A <see cref="string"/> that contains a separator string.
        /// </param>
        /// <typeparam name="T">
        /// The type of elements in the <paramref name="array"/>.
        /// </typeparam>
        /// <exception cref="ArgumentNullException">
        /// Is thrown when the <paramref name="array"/> parameter passed to a method is invalid because it is <see langword="null"/>.
        /// </exception>
        public static string ToString<T>(T[] array, string separator)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            var len = array.Length;
            if (len == 0)
                return String.Empty;

            if (separator == null)
                separator = String.Empty;

            var sb = new StringBuilder();
            Times(len - 1, i =>
              sb.AppendFormat("{0}{1}", array[i].ToString(), separator)
            );

            sb.Append(array[len - 1].ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Converts the specified <see cref="string"/> to a <see cref="Uri"/> object.
        /// </summary>
        /// <returns>
        /// A <see cref="Uri"/> converted from the <paramref name="uriString"/> parameter, or <see langword="null"/>
        /// if the <paramref name="uriString"/> is <see langword="null"/> or <see cref="String.Empty"/>.
        /// </returns>
        /// <param name="uriString">
        /// A <see cref="string"/> to convert.
        /// </param>
        public static Uri ToUri(string uriString)
        {
            return IsNullOrEmpty(uriString)
                   ? null
                   : MaybeUri(uriString)
                     ? new Uri(uriString)
                     : new Uri(uriString, UriKind.Relative);
        }

        /// <summary>
        /// Tries to create a new WebSocket <see cref="Uri"/> using the specified <paramref name="uriString"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the WebSocket <see cref="Uri"/> was successfully created; otherwise, <c>false</c>.
        /// </returns>
        /// <param name="uriString">
        /// A <see cref="string"/> that contains a WebSocket URI.
        /// </param>
        /// <param name="result">
        /// When this method returns, contains a created WebSocket <see cref="Uri"/> if the <paramref name="uriString"/> parameter is valid WebSocket URI; otherwise, <see langword="null"/>.
        /// </param>
        /// <param name="message">
        /// When this method returns, contains a error message <see cref="string"/> if the <paramref name="uriString"/> parameter is invalid WebSocket URI; otherwise, <c>String.Empty</c>.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Is thrown when the <paramref name="uriString"/> parameter passed to a method is invalid because it is <see langword="null"/>.
        /// </exception>
        public static bool TryCreateWebSocketUri(string uriString, out Uri result, out string message)
        {
            if (uriString == null)
                throw new ArgumentNullException("uriString");

            result = null;
            if (uriString == String.Empty)
            {
                message = "Must not be empty.";
                return false;
            }

            var uri = ToUri(uriString);
            if (!uri.IsAbsoluteUri)
            {
                message = "Not absolute URI: " + uriString;
                return false;
            }

            var scheme = uri.Scheme;
            if (scheme != "ws" && scheme != "wss")
            {
                message = "Unsupported scheme: " + scheme;
                return false;
            }

            var fragment = uri.Fragment;
            if (!String.IsNullOrEmpty(fragment))
            {
                message = "Must not contain the fragment component: " + uriString;
                return false;
            }

            var port = uri.Port;
            if (port > 0)
            {
                if ((scheme == "ws" && port == 443) ||
                    (scheme == "wss" && port == 80))
                {
                    message = String.Format(
                      "Invalid pair of scheme and port: {0}, {1}", scheme, port);
                    return false;
                }
            }

            result = uri;
            message = String.Empty;

            return true;
        }

        /// <summary>
        /// URL-decodes the specified <see cref="string"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that receives a decoded string, or the <paramref name="s"/> parameter
        /// if the <paramref name="s"/> is <see langword="null"/> or <see cref="String.Empty"/>.
        /// </returns>
        /// <param name="s">
        /// A <see cref="string"/> to decode.
        /// </param>
        public static string UrlDecode(string s)
        {
            return IsNullOrEmpty(s)
                   ? s
                   : HttpUtility.UrlDecode(s);
        }

        /// <summary>
        /// URL-encodes the specified <see cref="string"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that receives a encoded string, or the <paramref name="s"/> parameter
        /// if the <paramref name="s"/> is <see langword="null"/> or <see cref="String.Empty"/>.
        /// </returns>
        /// <param name="s">
        /// A <see cref="string"/> to encode.
        /// </param>
        public static string UrlEncode(string s)
        {
            return IsNullOrEmpty(s)
                   ? s
                   : HttpUtility.UrlEncode(s);
        }

        /// <summary>
        /// Writes the specified content data using the specified <see cref="WebSocketSharp.Net.HttpListenerResponse"/>.
        /// </summary>
        /// <param name="response">
        /// A <see cref="WebSocketSharp.Net.HttpListenerResponse"/> that contains a network stream to write a content data.
        /// </param>
        /// <param name="content">
        /// An array of <see cref="byte"/> that contains a content data to write.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Is thrown when the <paramref name="response"/> parameter passed to a method is invalid because it is <see langword="null"/>.
        /// </exception>
        public static void WriteContent(HttpListenerResponse response, byte[] content)
        {
            if (response == null)
                throw new ArgumentNullException("response");

            if (content == null || content.Length == 0)
                return;

            var output = response.OutputStream;
            response.ContentLength64 = content.Length;
            output.Write(content, 0, content.Length);
            output.Close();
        }

        #endregion
    }
}