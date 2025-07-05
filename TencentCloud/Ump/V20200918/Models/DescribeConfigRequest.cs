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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 摄像头签名
        /// </summary>
        [JsonProperty("CameraSign")]
        public string CameraSign{ get; set; }

        /// <summary>
        /// 摄像头app id
        /// </summary>
        [JsonProperty("CameraAppId")]
        public string CameraAppId{ get; set; }

        /// <summary>
        /// 摄像头时间戳，毫秒
        /// </summary>
        [JsonProperty("CameraTimestamp")]
        public long? CameraTimestamp{ get; set; }

        /// <summary>
        /// MAC地址，字母大写
        /// </summary>
        [JsonProperty("ServerMac")]
        public string ServerMac{ get; set; }

        /// <summary>
        /// 集团编码
        /// </summary>
        [JsonProperty("GroupCode")]
        public string GroupCode{ get; set; }

        /// <summary>
        /// 广场ID
        /// </summary>
        [JsonProperty("MallId")]
        public ulong? MallId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "CameraSign", this.CameraSign);
            this.SetParamSimple(map, prefix + "CameraAppId", this.CameraAppId);
            this.SetParamSimple(map, prefix + "CameraTimestamp", this.CameraTimestamp);
            this.SetParamSimple(map, prefix + "ServerMac", this.ServerMac);
            this.SetParamSimple(map, prefix + "GroupCode", this.GroupCode);
            this.SetParamSimple(map, prefix + "MallId", this.MallId);
        }
    }
}

