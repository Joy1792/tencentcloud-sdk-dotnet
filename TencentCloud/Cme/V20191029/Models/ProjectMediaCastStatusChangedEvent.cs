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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProjectMediaCastStatusChangedEvent : AbstractModel
    {
        
        /// <summary>
        /// 项目 Id。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目状态，取值有：
        /// <li>Started：点播转直播开始；</li>
        /// <li>Stopped：点播转直播结束；</li>
        /// <li>SourceInterrupted：点播转直播输入断流；</li>
        /// <li>DestinationInterrupted：点播转直播输出断流。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 点播转直播输入断流信息，仅当 Status 取值 SourceInterrupted 时有效。
        /// </summary>
        [JsonProperty("SourceInterruptInfo")]
        public MediaCastSourceInterruptInfo SourceInterruptInfo{ get; set; }

        /// <summary>
        /// 点播转直播输出断流信息，仅当 Status 取值 DestinationInterrupted 时有效。
        /// </summary>
        [JsonProperty("DestinationInterruptInfo")]
        public MediaCastDestinationInterruptInfo DestinationInterruptInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "SourceInterruptInfo.", this.SourceInterruptInfo);
            this.SetParamObj(map, prefix + "DestinationInterruptInfo.", this.DestinationInterruptInfo);
        }
    }
}

