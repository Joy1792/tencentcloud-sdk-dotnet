/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ModifyTimeWindowRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv 或者 cdbro-c1nl9rpv，与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 修改后的可维护时间段，其中每一个时间段的格式形如：10:00-12:00；起止时间按半个小时对齐；最短半个小时，最长三个小时；最多设置两个时间段；起止时间范围为：[00:00, 24:00]。
        /// 说明：设置两个时间段的 json 示例如下。
        /// [
        ///     "01:00-01:30",
        ///     "02:00-02:30"
        ///   ]
        /// </summary>
        [JsonProperty("TimeRanges")]
        public string[] TimeRanges{ get; set; }

        /// <summary>
        /// 指定修改哪一天的可维护时间段，可能的取值为：monday，tuesday，wednesday，thursday，friday，saturday，sunday。如果不指定该值或者为空，则默认一周七天都修改。
        /// 说明：指定修改多天的 json 示例如下。
        /// [
        ///     "monday",
        ///     "tuesday"
        ///   ]
        /// </summary>
        [JsonProperty("Weekdays")]
        public string[] Weekdays{ get; set; }

        /// <summary>
        /// 数据延迟阈值，仅对主实例和灾备实例有效，不传默认修改为10
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public ulong? MaxDelayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "TimeRanges.", this.TimeRanges);
            this.SetParamArraySimple(map, prefix + "Weekdays.", this.Weekdays);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
        }
    }
}

