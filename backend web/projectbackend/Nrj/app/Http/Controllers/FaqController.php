<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\FaqCategory;
use App\Models\FaqQuestion;


class FaqController extends Controller
{
   public function index()
    {
        // Controleer de admin-status van de gebruiker
        $user = auth()->user(); // Of gebruik een andere manier om de huidige gebruiker op te halen

        
            // De gebruiker is een admin
            // Voer hier de logica uit om de FAQ-pagina weer te geven
            $categories = FaqCategory::all();
            return view('faq.index', compact('categories'));
        
    }

public function store(Request $request)
{
    $validatedData = $request->validate([
        'category' => 'required',
        'question' => 'required',
        'answer' => 'required',
    ]);

    // Vind de categorie op basis van de naam
    $category = FaqCategory::where('name', $validatedData['category'])->first();

    // Als de categorie niet bestaat, maak er dan een nieuwe aan
    if (!$category) {
        $category = new FaqCategory();
        $category->name = $validatedData['category'];
        $category->save();
    }

    // Maak een nieuw vraag- en antwoordpaar
    $question = new FaqQuestion();
    $question->question = $validatedData['question'];
    $question->answer = $validatedData['answer'];
    $question->faq_category_id = $category->id;
    $question->category_id =$category->id;
    $question->save();

    return redirect()->back()->with('success', 'Vraag- en antwoordpaar is succesvol toegevoegd.');

}

public function showCategories()
{
    $categories = FaqCategory::all();

    return view('faq.faq-categories', compact('categories'));
}


public function postResponse(Request $request, $questionId)
{
    $question = FaqQuestion::findOrFail($questionId);

    // Voeg validatie toe aan de response
    $validatedData = $request->validate([
        'response' => 'required|min:3',
    ]);

    $question->response = $request->response;
    $question->save();

    return redirect()->back()->with('success', 'Response gepost!');
}


}
