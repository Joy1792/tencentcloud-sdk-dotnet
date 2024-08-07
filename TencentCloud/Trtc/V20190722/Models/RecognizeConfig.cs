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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeConfig : AbstractModel
    {
        
        /// <summary>
        /// 语音转文字支持识别的语言，默认是"zh" 中文
        /// 目前全量支持的语言如下，等号左面是语言英文名，右面是Language字段需要填写的值，该值遵循[ISO639](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes)：
        /// 可通过购买「语音转文本时长包」解锁或领取包月套餐体验版解锁此功能。
        /// 
        /// 语音转文本支持语言类型如下：
        /// - Chinese = "zh" # 中文
        /// - Chinese_TW = "zh-TW" # 中国台湾
        /// - English = "en" # 英语
        /// - Chinese_YUE = "zh-yue" # 中国粤语
        /// - Chinese_DIALECT = "zh-dialect" # 中国方言
        /// - English = "en" # 英语
        /// - Vietnamese = "vi" # 越南语
        /// - Japanese = "ja" # 日语
        /// - Korean = "ko" # 汉语
        /// - Indonesia = "id" # 印度尼西亚语
        /// - Thai = "th" # 泰语
        /// - Portuguese = "pt" # 葡萄牙语
        /// - Turkish = "tr" # 土耳其语
        /// - Arabic = "ar" # 阿拉伯语
        /// - Spanish = "es" # 西班牙语
        /// - Hindi = "hi" # 印地语
        /// - French = "fr" # 法语
        /// - Malay = "ms" # 马来语
        /// - Filipino = "fil" # 菲律宾语
        /// - German = "de" # 德语
        /// - Italian = "it" # 意大利语
        /// - Russian = "ru" # 俄语
        /// 
        /// 注意：
        /// 如果缺少满足您需求的语言，请联系我们技术人员。
        /// 示例值：zh
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// 发起模糊识别额外可能替代语言类型,最多填写3种语言类型。
        /// 注：Language指定为"zh-dialect" # 中国方言 时，不支持模糊识别，该字段无效
        /// </summary>
        [JsonProperty("AlternativeLanguage")]
        public string[] AlternativeLanguage{ get; set; }

        /// <summary>
        /// 使用的模型，目前支持tencent和google，默认是tencent。
        /// </summary>
        [JsonProperty("Model")]
        [System.Obsolete]
        public string Model{ get; set; }

        /// <summary>
        /// 翻译功能支持的语言，如果填写，则会启用翻译，不填则只会使用语音识别。
        /// 注：文本翻译功能需要购买「语音转文本时长包」解锁或领取包月套餐-体验版解。
        /// 目前全量支持的语言如下，等号左面是语言英文名，右面是Language字段需要填写的值，该值遵循[ISO639](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes)：
        /// Chinese = "zh"
        /// Chinese_TW = "zh-TW"
        /// English = "en"
        /// Vietnamese = "vi"
        /// Japanese = "ja"
        /// Korean = "ko"
        /// Indonesia = "id"
        /// Thai = "th"
        /// Portuguese = "pt"
        /// Turkish = "tr"
        /// Arabic = "ar"
        /// Spanish = "es"
        /// Hindi = "hi"
        /// French = "fr"
        /// Malay = "ms"
        /// Filipino = "fil"
        /// German = "de"
        /// Italian = "it"
        /// Russian = "ru"
        /// 
        /// 注意：
        /// 如果缺少满足您需求的语言，请联系我们技术人员。
        /// 示例值：en
        /// </summary>
        [JsonProperty("TranslationLanguage")]
        public string TranslationLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamArraySimple(map, prefix + "AlternativeLanguage.", this.AlternativeLanguage);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "TranslationLanguage", this.TranslationLanguage);
        }
    }
}

