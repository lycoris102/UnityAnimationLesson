# UnityAnimationLesson
## 概要
- Unity上でオブジェクトをアニメーションさせる方法の基本的なところについて書く

## NoScripting
- (1) Unityに標準搭載されているAnimation機能を使用する
- (2) 外部ツールで作成して変換する
  - e.g) FLASH変換ツール [uniSWF](http://uniswf.com/) [テラシュールブログさん紹介記事](http://tsubakit1.hateblo.jp/entry/20120613/1339595924)

## Animation
- http://docs.unity3d.com/ja/current/Manual/animeditor-UsingAnimationEditor.html
- (主に) GUIによる編集
  - ドープシート タイムラインモード
  - カーブ タイムライン モード
- ほぼ全てのコンポーネントの値にアクセス可能
- スプライトアニメーションも実装可能
  - スプライト画像の切り替えによるパラパラ漫画
- 成果物は [AnimationClip](http://docs.unity3d.com/ja/current/ScriptReference/AnimationClip.html)

### Init
- (1) Window > Animation
- (2) アニメーションを設定したいhierarchy上のゲームオブジェクトを選択
- (3) AnimationView上の[Create]ボタンを選択

### Howto (rec)
- (1) おもむろにAnimationView左上の[●]を押す
- (2) 任意のフレームをクリック/ドラッグで指定
- (3) Inspector上で値を変更するとproperty (キーフレーム左の項目) とキーフレーム (◇) が追加される
- (4) [Curves]を選択して「カーブ タイムライン モード」に切り替える
- (5) アニメーションカーブを設定する
- (6) [▶︎]を押して意図した挙動になっているか確認する

### Howto (SpriteAnimation)
- (1) ProjectView内にて複数のSpriteを選択する
  - Atalas化された画像の場合は予め[分割](http://docs.unity3d.com/ja/current/Manual/SpriteEditor.html)しておく
- (2) 選択したSprite群をまとめてSceneViewに放り込む
- (3) 適当な名称を付けてAnimationClipを保存 (Animatorも自動生成される)
- (4) お好みに応じてAnimationViewにて間隔調整をどうぞ

## Animator (meacanim)
- http://docs.unity3d.com/ja/current/Manual/Animator.html
- 複数のAnimationClipを状況に応じて切り替える君
- 主にキャラクターの動作制御で使われる事が多い
  - 待機/歩く/走る/ジャンプ/攻撃 ... etc

## Scripting
- Tween系アセットを使用する
  - `between` に由来する
- 始点/終点を指定して挙動を指定すると中間の処理を補間してくれるのが肝

### iTween
- https://www.assetstore.unity3d.com/jp/#!/content/84
- [リファレンス](http://itween.pixelplacement.com/documentation.php)
- Unity界隈で一番メジャーなTween系アセットで情報量も多い
- ハッシュによるパラメータの指定を行うので可読性は高い

### DOTween
- https://www.assetstore.unity3d.com/jp/#!/content/27676
- [リファレンス](http://dotween.demigiant.com/documentation.php)
- [ソース](https://github.com/Demigiant/dotween)
- [Sequence機能](http://dotween.demigiant.com/documentation.php#creatingSequence)
  - 複数の動きを組み合わせて一つのループとすることが出来る
- カスタムプロパティによる記法とショートカットによる利用
  - http://esakun.hateblo.jp/entry/2015/09/14/090000
- 各コンポーネントの拡張メソッドとして定義されている

### LeanTween
- https://www.assetstore.unity3d.com/jp/#!/content/3595
- [リファレンス](http://dentedpixel.com/LeanTweenDocumentation/classes/LeanTween.html)
- [ソース](https://github.com/dentedpixel/LeanTween)
- iOSに最適化されている
- あまり日本語の情報が落ちてない

### 各TweenAssetsのスピード比較
- http://dotween.demigiant.com/index.php#enginesComparison
- http://dentedpixel.com/developer-diary/leantween-speed-comparison-to-itween/
- iTweenはパフォーマンス的な側面からは使うの辛そう

### おまけ
- イージングの動作確認に役立ちそうなサイト
  - http://easings.net/ja
  - http://bl.ocks.org/hunzy/9929724
