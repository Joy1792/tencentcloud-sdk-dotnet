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

namespace TencentCloud.Icr.V20211014.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReqMetadata : AbstractModel
    {
        
        /// <summary>
        /// 渠道
        /// </summary>
        [JsonProperty("ChannelID")]
        public string ChannelID{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("BusinessName")]
        public string BusinessName{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("GUID")]
        public string GUID{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// 位置定位服务
        /// </summary>
        [JsonProperty("LBS")]
        public ReqMetadataLBS LBS{ get; set; }

        /// <summary>
        /// 透传字段
        /// </summary>
        [JsonProperty("Vagrants")]
        public ReqMetadataVagrant[] Vagrants{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelID", this.ChannelID);
            this.SetParamSimple(map, prefix + "BusinessName", this.BusinessName);
            this.SetParamSimple(map, prefix + "GUID", this.GUID);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamObj(map, prefix + "LBS.", this.LBS);
            this.SetParamArrayObj(map, prefix + "Vagrants.", this.Vagrants);
        }
    }
}

