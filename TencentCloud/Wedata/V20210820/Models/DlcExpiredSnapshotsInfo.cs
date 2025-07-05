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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcExpiredSnapshotsInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否启用快照过期治理项：enable、none
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpiredSnapshotsEnable")]
        public string ExpiredSnapshotsEnable{ get; set; }

        /// <summary>
        /// 用于运行快照过期治理项的引擎名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 需要保留的最近快照个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetainLast")]
        public ulong? RetainLast{ get; set; }

        /// <summary>
        /// 过期指定天前的快照
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeforeDays")]
        public ulong? BeforeDays{ get; set; }

        /// <summary>
        /// 清理过期快照的并行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxConcurrentDeletes")]
        public ulong? MaxConcurrentDeletes{ get; set; }

        /// <summary>
        /// 快照过期治理运行周期，单位为分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntervalMin")]
        public ulong? IntervalMin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpiredSnapshotsEnable", this.ExpiredSnapshotsEnable);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "RetainLast", this.RetainLast);
            this.SetParamSimple(map, prefix + "BeforeDays", this.BeforeDays);
            this.SetParamSimple(map, prefix + "MaxConcurrentDeletes", this.MaxConcurrentDeletes);
            this.SetParamSimple(map, prefix + "IntervalMin", this.IntervalMin);
        }
    }
}

