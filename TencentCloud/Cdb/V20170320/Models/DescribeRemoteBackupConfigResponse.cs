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

    public class DescribeRemoteBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 异地备份保留时间，单位为天
        /// </summary>
        [JsonProperty("ExpireDays")]
        public long? ExpireDays{ get; set; }

        /// <summary>
        /// 异地数据备份开关，off - 关闭异地备份，on-开启异地备份
        /// </summary>
        [JsonProperty("RemoteBackupSave")]
        public string RemoteBackupSave{ get; set; }

        /// <summary>
        /// 异地日志备份开关，off - 关闭异地备份，on-开启异地备份，只有在参数RemoteBackupSave为on时，RemoteBinlogSave参数才可设置为on
        /// </summary>
        [JsonProperty("RemoteBinlogSave")]
        public string RemoteBinlogSave{ get; set; }

        /// <summary>
        /// 用户已设置异地备份地域列表
        /// </summary>
        [JsonProperty("RemoteRegion")]
        public string[] RemoteRegion{ get; set; }

        /// <summary>
        /// 用户可设置异地备份地域列表
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

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
            this.SetParamSimple(map, prefix + "ExpireDays", this.ExpireDays);
            this.SetParamSimple(map, prefix + "RemoteBackupSave", this.RemoteBackupSave);
            this.SetParamSimple(map, prefix + "RemoteBinlogSave", this.RemoteBinlogSave);
            this.SetParamArraySimple(map, prefix + "RemoteRegion.", this.RemoteRegion);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

