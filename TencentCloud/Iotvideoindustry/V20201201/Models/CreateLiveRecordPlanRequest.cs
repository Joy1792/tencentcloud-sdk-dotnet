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

    public class CreateLiveRecordPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 录制计划名
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// 计划类型 1：固定直播 2：移动直播
        /// </summary>
        [JsonProperty("PlanType")]
        public long? PlanType{ get; set; }

        /// <summary>
        /// 时间模板ID,固定直播时为必填
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 录制文件存储时长，单位天，默认30天
        /// </summary>
        [JsonProperty("RecordStorageTime")]
        public long? RecordStorageTime{ get; set; }

        /// <summary>
        /// 绑定的直播频道ID列表
        /// </summary>
        [JsonProperty("LiveChannelIds")]
        public string[] LiveChannelIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "RecordStorageTime", this.RecordStorageTime);
            this.SetParamArraySimple(map, prefix + "LiveChannelIds.", this.LiveChannelIds);
        }
    }
}

