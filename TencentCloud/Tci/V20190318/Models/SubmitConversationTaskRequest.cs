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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitConversationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 音频源的语言，默认0为英文，1为中文
        /// </summary>
        [JsonProperty("Lang")]
        public long? Lang{ get; set; }

        /// <summary>
        /// 学生音频流
        /// </summary>
        [JsonProperty("StudentUrl")]
        public string StudentUrl{ get; set; }

        /// <summary>
        /// 教师音频流
        /// </summary>
        [JsonProperty("TeacherUrl")]
        public string TeacherUrl{ get; set; }

        /// <summary>
        /// 语音编码类型 1:pcm
        /// </summary>
        [JsonProperty("VoiceEncodeType")]
        public long? VoiceEncodeType{ get; set; }

        /// <summary>
        /// 语音文件类型 1:raw, 2:wav, 3:mp3（三种格式目前仅支持16k采样率16bit）
        /// </summary>
        [JsonProperty("VoiceFileType")]
        public long? VoiceFileType{ get; set; }

        /// <summary>
        /// 功能开关列表，表示是否需要打开相应的功能，返回相应的信息
        /// </summary>
        [JsonProperty("Functions")]
        public Function Functions{ get; set; }

        /// <summary>
        /// 识别词库名列表，评估过程使用这些词汇库中的词汇进行词汇使用行为分析
        /// </summary>
        [JsonProperty("VocabLibNameList")]
        public string[] VocabLibNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
            this.SetParamSimple(map, prefix + "StudentUrl", this.StudentUrl);
            this.SetParamSimple(map, prefix + "TeacherUrl", this.TeacherUrl);
            this.SetParamSimple(map, prefix + "VoiceEncodeType", this.VoiceEncodeType);
            this.SetParamSimple(map, prefix + "VoiceFileType", this.VoiceFileType);
            this.SetParamObj(map, prefix + "Functions.", this.Functions);
            this.SetParamArraySimple(map, prefix + "VocabLibNameList.", this.VocabLibNameList);
        }
    }
}

