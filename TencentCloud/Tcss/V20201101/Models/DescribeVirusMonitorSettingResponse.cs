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

    public class DescribeVirusMonitorSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否开启实时监控
        /// </summary>
        [JsonProperty("EnableScan")]
        public bool? EnableScan{ get; set; }

        /// <summary>
        /// 扫描全部路径
        /// </summary>
        [JsonProperty("ScanPathAll")]
        public bool? ScanPathAll{ get; set; }

        /// <summary>
        /// 当ScanPathAll为true 生效 0扫描以下路径 1、扫描除以下路径
        /// </summary>
        [JsonProperty("ScanPathType")]
        public ulong? ScanPathType{ get; set; }

        /// <summary>
        /// 自选排除或扫描的地址
        /// </summary>
        [JsonProperty("ScanPath")]
        public string[] ScanPath{ get; set; }

        /// <summary>
        /// 扫描路径模式：
        /// SCAN_PATH_ALL：全部路径
        /// SCAN_PATH_DEFAULT：默认路径
        /// SCAN_PATH_USER_DEFINE：用户自定义路径
        /// </summary>
        [JsonProperty("ScanPathMode")]
        public string ScanPathMode{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnableScan", this.EnableScan);
            this.SetParamSimple(map, prefix + "ScanPathAll", this.ScanPathAll);
            this.SetParamSimple(map, prefix + "ScanPathType", this.ScanPathType);
            this.SetParamArraySimple(map, prefix + "ScanPath.", this.ScanPath);
            this.SetParamSimple(map, prefix + "ScanPathMode", this.ScanPathMode);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

