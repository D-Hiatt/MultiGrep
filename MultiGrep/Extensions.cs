﻿// //
// //    Extensions.cs
// //
// //    Created on: 13 07 2017
// //        Author: David Hiatt - dhiatt89@gmail.com
// //
// //
// // Copyright (c) 2017 David Hiatt
// //
// //  This program is free software: you can redistribute it and/or modify
// //  it under the terms of the GNU Lesser General Public License as published by
// //  the Free Software Foundation, either version 3 of the License, or
// //  (at your option) any later version.
// //
// //  This program is distributed in the hope that it will be useful,
// //  but WITHOUT ANY WARRANTY; without even the implied warranty of
// //  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// //  GNU Lesser General Public License for more details.
// //
// //  You should have received a copy of the GNU Lesser General Public License
// //  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// //

using System;
using System.Collections.Generic;

namespace MultiGrep
{
    public static class Extension
    {
        /// <summary>
        /// A simple extensions to allow Linq style ForEach calls for any enumerable type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumer"></param>
        /// <param name="action"></param>
        public static void ForEach<T>(this IEnumerable<T> enumer, Action<T> action)
        {
            using(IEnumerator<T> all = enumer.GetEnumerator())
                while(all.MoveNext())
                    action(all.Current);
        }
    }
}