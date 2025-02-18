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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoomUser : AbstractModel
    {
        
        /// <summary>
        /// 房间id
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// 房间里用户uin列表
        /// </summary>
        [JsonProperty("Uins")]
        public ulong?[] Uins{ get; set; }

        /// <summary>
        /// 字符串房间id
        /// </summary>
        [JsonProperty("StrRoomId")]
        public string StrRoomId{ get; set; }

        /// <summary>
        /// 房间里用户字符串uin列表
        /// </summary>
        [JsonProperty("StrUins")]
        public string[] StrUins{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamArraySimple(map, prefix + "Uins.", this.Uins);
            this.SetParamSimple(map, prefix + "StrRoomId", this.StrRoomId);
            this.SetParamArraySimple(map, prefix + "StrUins.", this.StrUins);
        }
    }
}

