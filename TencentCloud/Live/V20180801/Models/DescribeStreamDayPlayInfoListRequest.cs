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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamDayPlayInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 日期，格式：YYYY-mm-dd。
        /// 第二天凌晨3点出昨天的数据，建议在这个时间点之后查询最新数据。支持最近3个月的数据查询。
        /// </summary>
        [JsonProperty("DayTime")]
        public string DayTime{ get; set; }

        /// <summary>
        /// 播放域名。
        /// </summary>
        [JsonProperty("PlayDomain")]
        public string PlayDomain{ get; set; }

        /// <summary>
        /// 页号，范围[1,1000]，默认值是1。
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 每页个数，范围[100,1000]，默认值是1000。
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 可选值：
        /// Mainland：查询国内数据，
        /// Oversea：则查询国外数据，
        /// 默认：查询国内+国外的数据。
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// 服务名称，可选值包括LVB(标准直播)，LEB(快直播)，不填则查LVB+LEB总值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DayTime", this.DayTime);
            this.SetParamSimple(map, prefix + "PlayDomain", this.PlayDomain);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
        }
    }
}

