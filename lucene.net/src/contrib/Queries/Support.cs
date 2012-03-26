/*
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 *
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucene.Net.Search
{
    static class Extensions
    {
        internal static bool EqualsToArrayList(this ArrayList me, ArrayList other)
        {
            if (me.Count != other.Count) return false;
            for (int i = 0; i < me.Count; i++)
            {
                if (me[i].Equals(other[i]) == false) return false;
            }
            return true;
        }
    }
}
