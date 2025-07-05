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

namespace TencentCloud.Tbm.V20180129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserPortraitResponse : AbstractModel
    {
        
        /// <summary>
        /// 年龄画像
        /// </summary>
        [JsonProperty("Age")]
        public AgePortraitInfo Age{ get; set; }

        /// <summary>
        /// 性别画像
        /// </summary>
        [JsonProperty("Gender")]
        public GenderPortraitInfo Gender{ get; set; }

        /// <summary>
        /// 省份画像
        /// </summary>
        [JsonProperty("Province")]
        public ProvincePortraitInfo Province{ get; set; }

        /// <summary>
        /// 电影喜好画像
        /// </summary>
        [JsonProperty("Movie")]
        public MoviePortraitInfo Movie{ get; set; }

        /// <summary>
        /// 明星喜好画像
        /// </summary>
        [JsonProperty("Star")]
        public StarPortraitInfo Star{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Age.", this.Age);
            this.SetParamObj(map, prefix + "Gender.", this.Gender);
            this.SetParamObj(map, prefix + "Province.", this.Province);
            this.SetParamObj(map, prefix + "Movie.", this.Movie);
            this.SetParamObj(map, prefix + "Star.", this.Star);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

