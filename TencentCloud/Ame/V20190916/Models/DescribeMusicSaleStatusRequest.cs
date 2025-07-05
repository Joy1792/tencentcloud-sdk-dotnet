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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMusicSaleStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 歌曲Id集合，可传单个，也可传多个，上线查询单次50个
        /// </summary>
        [JsonProperty("MusicIds")]
        public string[] MusicIds{ get; set; }

        /// <summary>
        /// 查询哪个渠道的数据，1为曲库包，2为单曲
        /// </summary>
        [JsonProperty("PurchaseType")]
        public long? PurchaseType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MusicIds.", this.MusicIds);
            this.SetParamSimple(map, prefix + "PurchaseType", this.PurchaseType);
        }
    }
}

