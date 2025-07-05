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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTimeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 时间模板名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否为每周全时录制（即7*24h录制），0：非全时录制，1；全时录制，默认0
        /// </summary>
        [JsonProperty("IsAllWeek")]
        public long? IsAllWeek{ get; set; }

        /// <summary>
        /// 当IsAllWeek为0时必选，用于描述模板的各个时间片段
        /// </summary>
        [JsonProperty("TimeTemplateSpecs")]
        public TimeTemplateSpec[] TimeTemplateSpecs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsAllWeek", this.IsAllWeek);
            this.SetParamArrayObj(map, prefix + "TimeTemplateSpecs.", this.TimeTemplateSpecs);
        }
    }
}

