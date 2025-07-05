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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStorageDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间，格式按照 ISO 8601标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#52)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，需大于开始日期，格式按照 ISO 8601标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#52)。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 统计时间粒度，有效值：
        /// <li>Minute：以5分钟为粒度。</li>
        /// <li>Day：以天为粒度。</li>
        /// 默认按时间跨度决定，小于等于1天以5分钟为粒度，大于1天则以天为粒度。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 查询的存储类型，有效值：
        /// <li>TotalStorage：存储总量，标准、低频、归档和深度归档存储量之和，不含提前删除量。</li>
        /// <li>StandardStorage：标准存储。</li>
        /// <li>InfrequentStorage：低频存储。</li>
        /// <li>ArchiveStorage：归档存储。</li>
        /// <li>DeepArchiveStorage：深度归档存储。</li>
        /// <li>DeletedInfrequentStorage：低频存储提前删除量。</li>
        /// <li>DeletedArchiveStorage：归档提前删除量。</li>
        /// <li>DeletedDeepArchiveStorage：深度归档提前删除量。</li>
        /// <li>ArchiveStandardRetrieval：归档标准取回量。</li>
        /// <li>ArchiveExpeditedRetrieval：归档快速取回量。</li>
        /// <li>ArchiveBulkRetrieval：归档批量取回量。</li>
        /// <li>DeepArchiveStandardRetrieval：深度归档标准取回量。</li>
        /// <li>DeepArchiveBulkRetrieval：深度归档批量取回量。</li>
        /// <li>InfrequentRetrieval：低频存储取回量。</li>
        /// 默认值为 TotalStorage。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 查询的存储区域，有效值：
        /// <li>Chinese Mainland：中国境内（不包含港澳台）。</li>
        /// <li>Outside Chinese Mainland：中国境外。</li>
        /// 默认值为 Chinese Mainland。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

