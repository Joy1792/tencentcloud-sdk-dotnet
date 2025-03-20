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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVirusFileStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 处理事件id
        /// </summary>
        [JsonProperty("EventIdSet")]
        public string[] EventIdSet{ get; set; }

        /// <summary>
        /// 标记事件的状态，       EVENT_DEALED:事件处理    EVENT_IGNORE"：事件忽略    EVENT_DEL:事件删除    EVENT_ADD_WHITE:事件加白    EVENT_PENDING: 事件待处理	EVENT_ISOLATE_CONTAINER: 隔离容器	EVENT_RESOTRE_CONTAINER: 恢复容器
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 事件备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否后续自动隔离相同MD5文件
        /// </summary>
        [JsonProperty("AutoIsolate")]
        public bool? AutoIsolate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EventIdSet.", this.EventIdSet);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AutoIsolate", this.AutoIsolate);
        }
    }
}

