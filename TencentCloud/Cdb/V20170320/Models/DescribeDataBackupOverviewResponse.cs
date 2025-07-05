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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataBackupOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前地域的数据备份总容量（包含自动备份和手动备份，单位为字节）。
        /// </summary>
        [JsonProperty("DataBackupVolume")]
        public long? DataBackupVolume{ get; set; }

        /// <summary>
        /// 当前地域的数据备份总个数。
        /// </summary>
        [JsonProperty("DataBackupCount")]
        public long? DataBackupCount{ get; set; }

        /// <summary>
        /// 当前地域的自动备份总容量。
        /// </summary>
        [JsonProperty("AutoBackupVolume")]
        public long? AutoBackupVolume{ get; set; }

        /// <summary>
        /// 当前地域的自动备份总个数。
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public long? AutoBackupCount{ get; set; }

        /// <summary>
        /// 当前地域的手动备份总容量。
        /// </summary>
        [JsonProperty("ManualBackupVolume")]
        public long? ManualBackupVolume{ get; set; }

        /// <summary>
        /// 当前地域的手动备份总个数。
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public long? ManualBackupCount{ get; set; }

        /// <summary>
        /// 异地备份总容量。
        /// </summary>
        [JsonProperty("RemoteBackupVolume")]
        public long? RemoteBackupVolume{ get; set; }

        /// <summary>
        /// 异地备份总个数。
        /// </summary>
        [JsonProperty("RemoteBackupCount")]
        public long? RemoteBackupCount{ get; set; }

        /// <summary>
        /// 当前地域归档备份总容量。
        /// </summary>
        [JsonProperty("DataBackupArchiveVolume")]
        public long? DataBackupArchiveVolume{ get; set; }

        /// <summary>
        /// 当前地域归档备份总个数。
        /// </summary>
        [JsonProperty("DataBackupArchiveCount")]
        public long? DataBackupArchiveCount{ get; set; }

        /// <summary>
        /// 当前地域标准存储备份总容量。
        /// </summary>
        [JsonProperty("DataBackupStandbyVolume")]
        public long? DataBackupStandbyVolume{ get; set; }

        /// <summary>
        /// 当前地域标准存储备份总个数。
        /// </summary>
        [JsonProperty("DataBackupStandbyCount")]
        public long? DataBackupStandbyCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataBackupVolume", this.DataBackupVolume);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupVolume", this.AutoBackupVolume);
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupVolume", this.ManualBackupVolume);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "RemoteBackupVolume", this.RemoteBackupVolume);
            this.SetParamSimple(map, prefix + "RemoteBackupCount", this.RemoteBackupCount);
            this.SetParamSimple(map, prefix + "DataBackupArchiveVolume", this.DataBackupArchiveVolume);
            this.SetParamSimple(map, prefix + "DataBackupArchiveCount", this.DataBackupArchiveCount);
            this.SetParamSimple(map, prefix + "DataBackupStandbyVolume", this.DataBackupStandbyVolume);
            this.SetParamSimple(map, prefix + "DataBackupStandbyCount", this.DataBackupStandbyCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

