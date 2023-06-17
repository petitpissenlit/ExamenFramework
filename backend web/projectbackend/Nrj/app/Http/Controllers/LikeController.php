<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Like;
use App\Models\Post;

use Auth;

class LikeController extends Controller
{
    public function __construct(){
        $this->middleware('auth');
    }


    public function like($postId, Request $request){

        $post = Post::findOrFail($postId);
        if($post->user_id == Auth::user()->id)
        abort(403,'cannot like own post');

        $like = Like::where('post_id', '=' , $postId)->where('user_id' , '=', Auth::user()->id)->first();

        if($like != NULL){
            abort(403,'cannot like more than once');
        }

        $like = new Like;
        $like->user_id = Auth::user()->id;
        $like->post_id = $postId;
        $like->save();

        return redirect()->route('index')->with('status','Post liked');

    }
}
