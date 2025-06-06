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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsrFullTextConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// 语音全文识别任务开关，可选值：
        /// <li>ON：开启智能语音全文识别任务；</li>
        /// <li>OFF：关闭智能语音全文识别任务。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 生成的字幕文件格式列表，不填或者填空数组表示不生成字幕文件，可选值：
        /// <li>vtt：生成 WebVTT 字幕文件；</li>
        /// <li>srt：生成 SRT 字幕文件。</li><font color=red>注意：</font>云点播媒资信息仅支持添加 vtt 字幕，因此当且仅当 SubtitleFormats 包含 vtt 时，云点播将生成的字幕添加到媒资。
        /// </summary>
        [JsonProperty("SubtitleFormats")]
        public string[] SubtitleFormats{ get; set; }

        /// <summary>
        /// 生成的字幕文件格式，不填或者填空字符串表示不生成字幕文件，可选值：
        /// <li>vtt：生成 WebVTT 字幕文件；</li>
        /// <li>srt：生成 SRT 字幕文件。</li>
        /// <font color='red'>注意：此字段已废弃，建议使用 SubtitleFormats。</font>
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        [System.Obsolete]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// 媒体源语言，取值范围：
        /// <li>zh：中文普通话；</li>
        /// <li>en：英语；</li>
        /// <li>ja：日语；</li>
        /// <li>zh-ca：粤语。</li>
        /// <font color=red>注意：</font> 填空字符串，或者不填该参数，则自动识别（效果较难保证，推荐填写原始媒体对应的语言，以提高识别的准确率）。
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// 指定字幕名称，长度限制：64 个字符。该值将用于播放器展示，若不填则云点播自动生成。
        /// <font color=red>注意：</font>仅当 SubtitleFormats 包含 vtt 时，该字段有效。
        /// </summary>
        [JsonProperty("SubtitleName")]
        public string SubtitleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "SubtitleFormats.", this.SubtitleFormats);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
        }
    }
}

