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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Tracks : AbstractModel
    {
        
        /// <summary>
        /// 跟踪集名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 跟踪事件类型（读：Read；写：Write；全部：*）
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 跟踪事件所属产品（如：cos，全部：*）
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 跟踪集状态（未开启：0；开启：1）
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 跟踪事件接口名列表（全部：[*]）
        /// </summary>
        [JsonProperty("EventNames")]
        public string[] EventNames{ get; set; }

        /// <summary>
        /// 数据投递存储（目前支持 cos、cls）
        /// </summary>
        [JsonProperty("Storage")]
        public Storage Storage{ get; set; }

        /// <summary>
        /// 跟踪集创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 跟踪集 ID
        /// </summary>
        [JsonProperty("TrackId")]
        public ulong? TrackId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "EventNames.", this.EventNames);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TrackId", this.TrackId);
        }
    }
}

