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

namespace TencentCloud.Soe.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransmitOralProcessWithInitResponse : AbstractModel
    {
        
        /// <summary>
        /// 发音精准度，取值范围[-1, 100]，当取-1时指完全不匹配，当为句子模式时，是所有已识别单词准确度的加权平均值，在reftext中但未识别出来的词不计入分数中。当为流式模式且请求中IsEnd未置1时，取值无意义。
        /// </summary>
        [JsonProperty("PronAccuracy")]
        public float? PronAccuracy{ get; set; }

        /// <summary>
        /// 发音流利度，取值范围[0, 1]，当为词模式时，取值无意义；当为流式模式且请求中IsEnd未置1时，取值无意义。取值无意义时，值为-1
        /// </summary>
        [JsonProperty("PronFluency")]
        public float? PronFluency{ get; set; }

        /// <summary>
        /// 发音完整度，取值范围[0, 1]，当为词模式或自由说模式时，取值无意义；当为流式模式且请求中IsEnd未置1时，取值无意义。取值无意义时，值为-1
        /// </summary>
        [JsonProperty("PronCompletion")]
        public float? PronCompletion{ get; set; }

        /// <summary>
        /// 详细发音评估结果
        /// </summary>
        [JsonProperty("Words")]
        public WordRsp[] Words{ get; set; }

        /// <summary>
        /// 语音段唯一标识，一段语音一个SessionId
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 已废弃，不再保存语音音频文件下载地址
        /// </summary>
        [JsonProperty("AudioUrl")]
        [System.Obsolete]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// 断句中间结果，中间结果是局部最优而非全局最优的结果，所以中间结果有可能和最终整体结果对应部分不一致；中间结果的输出便于客户端UI更新；待用户发音完全结束后，系统会给出一个综合所有句子的整体结果。
        /// </summary>
        [JsonProperty("SentenceInfoSet")]
        public SentenceInfo[] SentenceInfoSet{ get; set; }

        /// <summary>
        /// 评估 session 状态，“Evaluating"：评估中、"Failed"：评估失败、"Finished"：评估完成
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 建议评分，取值范围[0,100]，评分方式为建议评分 = 准确度（PronAccuracy）× 完整度（PronCompletion）×（2 - 完整度（PronCompletion）），如若评分策略不符合请参考Words数组中的详细分数自定义评分逻辑。
        /// </summary>
        [JsonProperty("SuggestedScore")]
        public float? SuggestedScore{ get; set; }

        /// <summary>
        /// 匹配候选文本的序号，在句子多分支、情景对 话、段落模式下表示匹配到的文本序号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefTextId")]
        public long? RefTextId{ get; set; }

        /// <summary>
        /// 主题词命中标志，0表示没命中，1表示命中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyWordHits")]
        public float?[] KeyWordHits{ get; set; }

        /// <summary>
        /// 负向主题词命中标志，0表示没命中，1表示命中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnKeyWordHits")]
        public float?[] UnKeyWordHits{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PronAccuracy", this.PronAccuracy);
            this.SetParamSimple(map, prefix + "PronFluency", this.PronFluency);
            this.SetParamSimple(map, prefix + "PronCompletion", this.PronCompletion);
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamArrayObj(map, prefix + "SentenceInfoSet.", this.SentenceInfoSet);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SuggestedScore", this.SuggestedScore);
            this.SetParamSimple(map, prefix + "RefTextId", this.RefTextId);
            this.SetParamArraySimple(map, prefix + "KeyWordHits.", this.KeyWordHits);
            this.SetParamArraySimple(map, prefix + "UnKeyWordHits.", this.UnKeyWordHits);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

