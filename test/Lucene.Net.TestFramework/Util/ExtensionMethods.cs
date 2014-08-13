﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Lucene.Net.Util
{
    using System;
    using Lucene.Net.Random;
    /// <summary>
    /// Extension methods to make writing tests easier.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Performs a loop for the specified number of times. 
        /// </summary>
        /// <param name="value">The number of times to perform a loop.</param>
        /// <param name="invoke">The code that should be ivnoked for each iteration.</param>
        public static void Times(this int value, Action<int> invoke)
        {
            for(var i = 0; i < value; i++)
            {
                invoke(i);
            }
        }

    }
}
