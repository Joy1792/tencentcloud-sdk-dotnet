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

    public class KTVMusicDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 即使广播曲库歌曲基础信息
        /// </summary>
        [JsonProperty("KTVMusicBaseInfo")]
        public KTVMusicBaseInfo KTVMusicBaseInfo{ get; set; }

        /// <summary>
        /// 播放凭证
        /// </summary>
        [JsonProperty("PlayToken")]
        public string PlayToken{ get; set; }

        /// <summary>
        /// 歌词下载地址
        /// </summary>
        [JsonProperty("LyricsUrl")]
        public string LyricsUrl{ get; set; }

        /// <summary>
        /// 歌曲规格信息列表
        /// </summary>
        [JsonProperty("DefinitionInfoSet")]
        public KTVMusicDefinitionInfo[] DefinitionInfoSet{ get; set; }

        /// <summary>
        /// 音高数据文件下载地址
        /// </summary>
        [JsonProperty("MidiJsonUrl")]
        public string MidiJsonUrl{ get; set; }

        /// <summary>
        /// 副歌片段数据列表
        /// </summary>
        [JsonProperty("ChorusClipSet")]
        public ChorusClip[] ChorusClipSet{ get; set; }

        /// <summary>
        /// 前奏间隔，单位：毫秒；注：若参数返回为0则无人声部分
        /// </summary>
        [JsonProperty("PreludeInterval")]
        public long? PreludeInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "KTVMusicBaseInfo.", this.KTVMusicBaseInfo);
            this.SetParamSimple(map, prefix + "PlayToken", this.PlayToken);
            this.SetParamSimple(map, prefix + "LyricsUrl", this.LyricsUrl);
            this.SetParamArrayObj(map, prefix + "DefinitionInfoSet.", this.DefinitionInfoSet);
            this.SetParamSimple(map, prefix + "MidiJsonUrl", this.MidiJsonUrl);
            this.SetParamArrayObj(map, prefix + "ChorusClipSet.", this.ChorusClipSet);
            this.SetParamSimple(map, prefix + "PreludeInterval", this.PreludeInterval);
        }
    }
}

