/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCastDestinationInterruptInfo : AbstractModel
    {
        
        /// <summary>
        /// 发生断流的输出源信息。
        /// </summary>
        [JsonProperty("DestinationInfo")]
        public MediaCastDestinationInfo DestinationInfo{ get; set; }

        /// <summary>
        /// 输出源断流原因，取值有：
        /// <li>SystemError：系统错误；</li>
        /// <li>Unknown：未知错误。</li>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DestinationInfo.", this.DestinationInfo);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

