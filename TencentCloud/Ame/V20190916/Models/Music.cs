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

    public class Music : AbstractModel
    {
        
        /// <summary>
        /// 音乐播放链接相对路径，必须通过在正版曲库直通车控制台上登记的域名进行拼接。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 音频文件大小
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// 音频文件类型
        /// </summary>
        [JsonProperty("FileExtension")]
        public string FileExtension{ get; set; }

        /// <summary>
        /// Song fragment start.试听片段开始时间，试听时长为auditionEnd-auditionBegin
        /// Unit :ms
        /// </summary>
        [JsonProperty("AuditionBegin")]
        public ulong? AuditionBegin{ get; set; }

        /// <summary>
        /// Song fragment end.试听片段结束时间, 试听时长为auditionEnd-auditionBegin
        /// Unit :ms
        /// </summary>
        [JsonProperty("AuditionEnd")]
        public ulong? AuditionEnd{ get; set; }

        /// <summary>
        /// 音乐播放链接全路径，前提是在正版曲库直通车控制台添加过域名，否则返回空字符。
        /// 如果添加过多个域名只返回第一个添加域名的播放全路径。
        /// </summary>
        [JsonProperty("FullUrl")]
        public string FullUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileExtension", this.FileExtension);
            this.SetParamSimple(map, prefix + "AuditionBegin", this.AuditionBegin);
            this.SetParamSimple(map, prefix + "AuditionEnd", this.AuditionEnd);
            this.SetParamSimple(map, prefix + "FullUrl", this.FullUrl);
        }
    }
}

