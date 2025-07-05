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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PurgePathCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// 目录列表，需要包含协议头部 http:// 或 https://
        /// </summary>
        [JsonProperty("Paths")]
        public string[] Paths{ get; set; }

        /// <summary>
        /// 刷新类型
        /// flush：刷新产生更新的资源
        /// delete：刷新全部资源
        /// </summary>
        [JsonProperty("FlushType")]
        public string FlushType{ get; set; }

        /// <summary>
        /// 是否对中文字符进行编码后刷新
        /// </summary>
        [JsonProperty("UrlEncode")]
        public bool? UrlEncode{ get; set; }

        /// <summary>
        /// 刷新区域
        /// 无此参数时，默认刷新加速域名所在加速区域
        /// 填充 mainland 时，仅刷新中国境内加速节点上缓存内容
        /// 填充 overseas 时，仅刷新中国境外加速节点上缓存内容
        /// 指定刷新区域时，需要与域名加速区域匹配
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Paths.", this.Paths);
            this.SetParamSimple(map, prefix + "FlushType", this.FlushType);
            this.SetParamSimple(map, prefix + "UrlEncode", this.UrlEncode);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

