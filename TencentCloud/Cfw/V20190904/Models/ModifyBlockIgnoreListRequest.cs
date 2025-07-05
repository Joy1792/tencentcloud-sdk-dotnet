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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBlockIgnoreListRequest : AbstractModel
    {
        
        /// <summary>
        /// 1封禁列表 2 放通列表
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// IP、Domain二选一（注：封禁列表，只能填写IP），不能同时为空
        /// </summary>
        [JsonProperty("IOC")]
        public IocListData[] IOC{ get; set; }

        /// <summary>
        /// 可选值：delete（删除）、edit（编辑）、add（添加）  其他值无效
        /// </summary>
        [JsonProperty("IocAction")]
        public string IocAction{ get; set; }

        /// <summary>
        /// 时间格式：yyyy-MM-dd HH:mm:ss，IocAction 为edit或add时必填
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 时间格式：yyyy-MM-dd HH:mm:ss，IocAction 为edit或add时必填，必须大于当前时间且大于StartTime
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArrayObj(map, prefix + "IOC.", this.IOC);
            this.SetParamSimple(map, prefix + "IocAction", this.IocAction);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

