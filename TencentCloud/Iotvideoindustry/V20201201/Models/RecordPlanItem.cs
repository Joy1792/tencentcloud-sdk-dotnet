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

    public class RecordPlanItem : AbstractModel
    {
        
        /// <summary>
        /// 计划ID
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 时间模板ID
        /// </summary>
        [JsonProperty("TimeTemplateId")]
        public string TimeTemplateId{ get; set; }

        /// <summary>
        /// 时间模板名称
        /// </summary>
        [JsonProperty("TimeTemplateName")]
        public string TimeTemplateName{ get; set; }

        /// <summary>
        /// 录制类型
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// 绑定的设备列表
        /// </summary>
        [JsonProperty("Devices")]
        public DeviceItem[] Devices{ get; set; }

        /// <summary>
        /// 录像存储天数
        /// </summary>
        [JsonProperty("RecordStorageTime")]
        public long? RecordStorageTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TimeTemplateId", this.TimeTemplateId);
            this.SetParamSimple(map, prefix + "TimeTemplateName", this.TimeTemplateName);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamArrayObj(map, prefix + "Devices.", this.Devices);
            this.SetParamSimple(map, prefix + "RecordStorageTime", this.RecordStorageTime);
        }
    }
}

