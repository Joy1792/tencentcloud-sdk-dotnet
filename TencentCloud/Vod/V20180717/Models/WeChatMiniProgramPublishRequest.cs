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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WeChatMiniProgramPublishRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件 ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 发布视频所对应的转码模板 ID，为 0 代表原始视频。支持的视频格式：
        /// <li>当 SourceDefinition 为 0 时，视频格式支持 MP4、3GP 格式；</li>
        /// <li>当 SourceDefinition 大于 0 时，视频格式支持 MP4、3GP 及 M3U8 格式。</li>不填默认值为 0。
        /// </summary>
        [JsonProperty("SourceDefinition")]
        public long? SourceDefinition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SourceDefinition", this.SourceDefinition);
        }
    }
}

