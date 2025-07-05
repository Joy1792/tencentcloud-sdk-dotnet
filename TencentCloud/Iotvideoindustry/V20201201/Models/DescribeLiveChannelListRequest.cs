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

    public class DescribeLiveChannelListRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 最大数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 直播频道类型，1：固定直播；2：移动直播
        /// </summary>
        [JsonProperty("LiveChannelType")]
        public long? LiveChannelType{ get; set; }

        /// <summary>
        /// 直播录制计划ID, null: 直播录制计划为空
        /// </summary>
        [JsonProperty("RecordPlanId")]
        public string RecordPlanId{ get; set; }

        /// <summary>
        /// 频道名称 (支持模糊搜索)
        /// </summary>
        [JsonProperty("LiveChannelName")]
        public string LiveChannelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "LiveChannelType", this.LiveChannelType);
            this.SetParamSimple(map, prefix + "RecordPlanId", this.RecordPlanId);
            this.SetParamSimple(map, prefix + "LiveChannelName", this.LiveChannelName);
        }
    }
}

