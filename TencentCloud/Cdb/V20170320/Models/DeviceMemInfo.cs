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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceMemInfo : AbstractModel
    {
        
        /// <summary>
        /// 总内存大小。free命令中Mem:一行total的值,单位：KB
        /// </summary>
        [JsonProperty("Total")]
        public long?[] Total{ get; set; }

        /// <summary>
        /// 已使用内存。free命令中Mem:一行used的值,单位：KB
        /// </summary>
        [JsonProperty("Used")]
        public long?[] Used{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Total.", this.Total);
            this.SetParamArraySimple(map, prefix + "Used.", this.Used);
        }
    }
}

