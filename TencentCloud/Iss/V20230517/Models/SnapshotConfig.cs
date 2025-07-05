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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotConfig : AbstractModel
    {
        
        /// <summary>
        /// 截图频率。可选值1～20秒
        /// </summary>
        [JsonProperty("TimeInterval")]
        public ulong? TimeInterval{ get; set; }

        /// <summary>
        /// 模板生效的时间段。最多包含5组时间段
        /// </summary>
        [JsonProperty("OperTimeSlot")]
        public OperTimeSlot[] OperTimeSlot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeInterval", this.TimeInterval);
            this.SetParamArrayObj(map, prefix + "OperTimeSlot.", this.OperTimeSlot);
        }
    }
}

