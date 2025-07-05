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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveVipUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 房间标识。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 直播会员结束时间。
        /// </summary>
        [JsonProperty("LiveVipEndTime")]
        public string LiveVipEndTime{ get; set; }

        /// <summary>
        /// 会员生效状态
        /// <li>Valid：生效</li><li>Invalid：无效</li>
        /// </summary>
        [JsonProperty("LiveVipStatus")]
        public string LiveVipStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "LiveVipEndTime", this.LiveVipEndTime);
            this.SetParamSimple(map, prefix + "LiveVipStatus", this.LiveVipStatus);
        }
    }
}

