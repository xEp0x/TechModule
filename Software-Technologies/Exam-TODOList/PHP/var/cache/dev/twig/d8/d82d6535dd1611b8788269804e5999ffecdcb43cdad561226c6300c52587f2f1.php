<?php

/* task/delete.html.twig */
class __TwigTemplate_51e994fb33b2a018c8423b8fdeaaaca1f9f17a26636ed524b479f58726972f2b extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "task/delete.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_a9d8a0418c0149956eb166be853514fb95b53cf912a57c9553ff0da7a015568d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a9d8a0418c0149956eb166be853514fb95b53cf912a57c9553ff0da7a015568d->enter($__internal_a9d8a0418c0149956eb166be853514fb95b53cf912a57c9553ff0da7a015568d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "task/delete.html.twig"));

        $__internal_37dae1d02e1077cf78ff5fbd63d8a65d0189ca9f6dc0c8aed0db410fd6cff867 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_37dae1d02e1077cf78ff5fbd63d8a65d0189ca9f6dc0c8aed0db410fd6cff867->enter($__internal_37dae1d02e1077cf78ff5fbd63d8a65d0189ca9f6dc0c8aed0db410fd6cff867_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "task/delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_a9d8a0418c0149956eb166be853514fb95b53cf912a57c9553ff0da7a015568d->leave($__internal_a9d8a0418c0149956eb166be853514fb95b53cf912a57c9553ff0da7a015568d_prof);

        
        $__internal_37dae1d02e1077cf78ff5fbd63d8a65d0189ca9f6dc0c8aed0db410fd6cff867->leave($__internal_37dae1d02e1077cf78ff5fbd63d8a65d0189ca9f6dc0c8aed0db410fd6cff867_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_2cec1c14d52873b32180f0688b90f34994944c4beaf71626922b389cd80cef13 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2cec1c14d52873b32180f0688b90f34994944c4beaf71626922b389cd80cef13->enter($__internal_2cec1c14d52873b32180f0688b90f34994944c4beaf71626922b389cd80cef13_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_2d7c54bd43a63501868781de15ff733808c67496ea6e74fab3274ffd1590bb6f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2d7c54bd43a63501868781de15ff733808c67496ea6e74fab3274ffd1590bb6f->enter($__internal_2d7c54bd43a63501868781de15ff733808c67496ea6e74fab3274ffd1590bb6f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div id=\"delete-wrapper\">
        <section class=\"delete\">
            <article>
                <form action=\"";
        // line 7
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("delete", array("id" => $this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "id", array()))), "html", null, true);
        echo "\" method=\"POST\">
                    <h4>Do you want to delete this item?</h4>
                    <div class=\"box\">
                        <p>";
        // line 10
        echo twig_escape_filter($this->env, $this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "title", array()), "html", null, true);
        echo "</p>
                    </div>
                    <div class=\"box\">
                        <p class=\"description\">";
        // line 13
        echo twig_escape_filter($this->env, $this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "comments", array()), "html", null, true);
        echo "</p>
                    </div>

                    ";
        // line 16
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                    <button type=\"submit\">Delete</button>
                    <a href=\"";
        // line 19
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\">Cancel</a>
                </form>
            </article>
        </section>
    </div>
";
        
        $__internal_2d7c54bd43a63501868781de15ff733808c67496ea6e74fab3274ffd1590bb6f->leave($__internal_2d7c54bd43a63501868781de15ff733808c67496ea6e74fab3274ffd1590bb6f_prof);

        
        $__internal_2cec1c14d52873b32180f0688b90f34994944c4beaf71626922b389cd80cef13->leave($__internal_2cec1c14d52873b32180f0688b90f34994944c4beaf71626922b389cd80cef13_prof);

    }

    public function getTemplateName()
    {
        return "task/delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 19,  72 => 16,  66 => 13,  60 => 10,  54 => 7,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
    <div id=\"delete-wrapper\">
        <section class=\"delete\">
            <article>
                <form action=\"{{ path('delete', {'id': task.id}) }}\" method=\"POST\">
                    <h4>Do you want to delete this item?</h4>
                    <div class=\"box\">
                        <p>{{ task.title }}</p>
                    </div>
                    <div class=\"box\">
                        <p class=\"description\">{{ task.comments }}</p>
                    </div>

                    {{ form_row(form._token) }}

                    <button type=\"submit\">Delete</button>
                    <a href=\"{{ path('index') }}\">Cancel</a>
                </form>
            </article>
        </section>
    </div>
{% endblock %}", "task/delete.html.twig", "D:\\PROJECTS\\Software Technologies\\17. ExamPreparationI\\PHP Skeleton\\app\\Resources\\views\\task\\delete.html.twig");
    }
}
